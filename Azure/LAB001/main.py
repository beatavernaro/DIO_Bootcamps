import streamlit as st
from azure.storage.blob import BlobServiceClient
import os
import pymssql
import uuid
import json
from dotenv import load_dotenv

load_dotenv()
blobConnectionString = os.getenv("BLOB_CONNECTION_STRING")
blobContainerName = os.getenv("BLOB_CONTAINER_NAME")
blobAccountName = os.getenv("BLOB_ACCOUNT_NAME")

SQL_SERVER = os.getenv("SQL_SERVER")
SQL_DATABASE = os.getenv("SQL_DATABASE")
SQL_USERNAME = os.getenv("SQL_USERNAME")
SQL_PASSWORD = os.getenv("SQL_PASSWORD")

st.title("Cadastro de Produtos")
product_name = st.text_input("Nome do Produto")
product_description = st.text_area("Descrição do Produto")
product_price = st.number_input("Preço do Produto", min_value=0.0, format="%.2f")
product_image = st.file_uploader("Imagem do Produto", type=["jpg", "jpeg", "png"])

def upload_blob(file):
    blob_service_client = BlobServiceClient.from_connection_string(blobConnectionString)
    container_client = blob_service_client.get_container_client(blobContainerName)
    blob_name = str(uuid.uuid4()) + file.name
    blob_client = container_client.get_blob_client(blob_name)
    blob_client.upload_blob(file.read(), overwrite=True)
    image_url = f"https://{blobAccountName}.blob.core.windows.net/{blobContainerName}/{blob_name}"
    return image_url

def insert_product(product_name, product_description, product_price, image_url):
    try:
        image_url = upload_blob(product_image)
        connection = pymssql.connect(
            host=SQL_SERVER,
            user=SQL_USERNAME,
            password=SQL_PASSWORD,
            database=SQL_DATABASE
        )
        cursor = connection.cursor()
        sql = "INSERT INTO Produtos (nome, descricao, preco, imagem_url) VALUES (%s, %s, %s, %s)"
        cursor.execute(sql, (product_name, product_description, product_price, image_url))
        connection.commit()
        cursor.close()
        connection.close()
        return True
    except Exception as e:
        st.error(f"Erro ao cadastrar produto: {e}")
        return False

def list_products():
    try:
        connection = pymssql.connect(
            host=SQL_SERVER,
            user=SQL_USERNAME,
            password=SQL_PASSWORD,
            database=SQL_DATABASE
        )
        cursor = connection.cursor()
        sql = "SELECT * FROM Produtos"
        cursor.execute(sql)
        products = cursor.fetchall()
        cursor.close()
        connection.close()
        return products
    except Exception as e:
        st.error(f"Erro ao listar produtos: {e}")
        return []

def display_products():
    products = list_products()
    if products:
        cards_por_linha = 3
        cols = st.columns(cards_por_linha)
        for i, product in enumerate(products):
            with cols[i % cards_por_linha]:
                st.markdown(f"### {product[1]}")
                if product[4]:
                    html_img = f'<img src="{product[4]}" alt="Imagem do Produto" style="width: 200px; height: 200px;">'
                    st.markdown(html_img, unsafe_allow_html=True)
                st.write(f"**Descrição:** {product[2]}")
                st.write(f"**Preço:** R$ {product[3]:.2f}")
                st.markdown("---")
            if (i + 1) % cards_por_linha == 0 and (i + 1) < len(products):
                cols = st.columns(cards_por_linha)
    else:
        st.write("Nenhum produto cadastrado.")
        
if st.button("Cadastrar Produto"):
    insert_product(product_name, product_description, product_price, product_image)
    display_products()
    return_message = "Produto cadastrado com sucesso!"

st.header("Produtos Cadastrados")

if st.button("Listar Produtos"):
    display_products()
    return_message = 'Produtos Listados com sucesso!'