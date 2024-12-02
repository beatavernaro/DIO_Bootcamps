SELECT Nome, Ano FROM Filmes;

SELECT Nome, Ano FROM Filmes
ORDER BY Ano

SELECT Nome, Ano, Duracao FROM Filmes
WHERE Nome = 'De Volta para o Futuro'

SELECT Nome, Ano, Duracao FROM Filmes
WHERE Ano = 1997

SELECT Nome, Ano, Duracao FROM Filmes
WHERE Ano > 2000

SELECT Nome, Ano, Duracao FROM Filmes
WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao

SELECT Ano, COUNT(*) AS Quantidade
FROM Filmes
GROUP BY Ano
ORDER BY SUM(Duracao) DESC

SELECT * FROM Atores WHERE Genero = 'M'

SELECT * FROM Atores WHERE Genero = 'F'
ORDER BY PrimeiroNome

SELECT * FROM ElencoFilme

SELECT f.Nome, g.Genero
FROM Filmes f
JOIN FilmesGenero fg ON F.Id = fg.IdFilme
JOIN Generos g ON Fg.IdGenero = g.Id

SELECT f.Nome, g.Genero
FROM Filmes f
JOIN FilmesGenero fg ON F.Id = fg.IdFilme
JOIN Generos g ON Fg.IdGenero = g.Id
WHERE g.Genero = 'Mistério'

SELECT f.Nome, a.PrimeiroNome, a.UltimoNome, e.Papel
From Filmes f
JOIN Atores a ON f.Id = a.Id
JOIN ElencoFilme e ON a.Id = e.IdAtor