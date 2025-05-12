# LAB 001 - Cadastro de Produtos com Azure e Streamlit

Este projeto é uma aplicação web desenvolvida em Python utilizando o framework **Streamlit** para cadastro e exibição de produtos. A aplicação integra com o **Azure Blob Storage** para armazenamento de imagens e com um banco de dados SQL hospedado no **Azure SQL Database** para persistência dos dados dos produtos.

## Funcionalidades

- **Cadastro de Produtos**: Permite inserir o nome, descrição, preço e imagem de um produto.
- **Upload de Imagens**: As imagens dos produtos são armazenadas no Azure Blob Storage.
- **Listagem de Produtos**: Exibe os produtos cadastrados em formato de cards, incluindo nome, descrição, preço e imagem.

## Tecnologias Utilizadas

- **Python**: Linguagem de programação principal.
- **Streamlit**: Framework para criação de aplicações web interativas.
- **Azure Blob Storage**: Armazenamento de imagens dos produtos.
- **Azure SQL Database**: Banco de dados para persistência das informações dos produtos.
- **pymssql**: Biblioteca para conexão com o banco de dados SQL.
- **python-dotenv**: Gerenciamento de variáveis de ambiente.

## Configuração

1. **Clonar o repositório**:

   ```bash
   git clone <url-do-repositorio>
   cd LAB001

   ```

2. Instalar as dependências: Certifique-se de ter o Python instalado e execute:

   `pip install -r requirements.txt`

3. Configurar variáveis de ambiente: Preencha o arquivo .env com as credenciais do Azure Blob Storage e do banco de dados SQL. Exemplo:

   ```BLOB_CONNECTION_STRING="sua-string-de-conexao"
   BLOB_CONTAINER_NAME="nome-do-container"
   BLOB_ACCOUNT_NAME="nome-da-conta"

   SQL_SERVER="servidor-sql"
   SQL_DATABASE="nome-do-banco"
   SQL_USERNAME="usuario"
   SQL_PASSWORD="senha"
   ```

4. Executar a aplicação: Inicie o servidor Streamlit:

   `streamlit run main.py`
