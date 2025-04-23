-- 1 - Buscar o nome e ano dos filmes (OK)

SELECT 
Nome, Ano
FROM Filmes

-- 2 - Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano (OK)

SELECT 
Nome, Ano, Duracao
FROM Filmes
ORDER BY Ano ASC

-- 3 - Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a duração (OK)

SELECT * FROM Filmes
WHERE Nome = 'De Volta para o futuro'

-- 4 - Buscar os filmes lançados em 1997 (OK)

SELECT * FROM Filmes
WHERE Ano = 1997

-- 5 - Buscar os filmes lançados APÓS o ano 2000 (OK)

SELECT * FROM Filmes 
WHERE Ano > 2000

-- 6 - Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente (OK)

SELECT * FROM Filmes
WHERE Duracao > 100 AND Duracao < 150
ORDER BY Duracao ASC

-- 7 - Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duracao em ordem decrescente (OK)

SELECT Ano, COUNT(*) 
AS Quantidade 
FROM Filmes 
GROUP BY Ano
ORDER BY Quantidade DESC;

-- 8 - Buscar os Atores do gênero masculino, retornando o PrimeiroNome, UltimoNome (OK)

SELECT PrimeiroNome, UltimoNome, Genero 
FROM Atores
WHERE Genero = 'M'

-- 9 - Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome (OK)

SELECT PrimeiroNome, UltimoNome, Genero 
FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome ASC

-- 10 - Buscar o nome do filme e o gênero (OK)

SELECT f.Nome AS NomeDoFilme, g.Genero AS NomeDoGenero
FROM Filmes f
JOIN FilmesGenero fg ON f.Id = fg.IdFilme
JOIN Generos g ON g.Id = fg.idGenero;

-- 11 - Buscar o nome do filme e o gênero do tipo "Mistério" (OK)

SELECT f.Nome AS NomeDoFilme, g.Genero AS NomeDoGenero
FROM Filmes f
JOIN FilmesGenero fg ON f.Id = fg.IdFilme
JOIN Generos g ON g.Id = fg.idGenero
WHERE Genero = 'Mistério'

-- 12 - Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel (OK)

SELECT Filmes.Nome, Atores.PrimeiroNome, Atores.UltimoNome, ElencoFilme.Papel
FROM Filmes
INNER JOIN ElencoFilme ON Filmes.Id = ElencoFilme.IdFilme
INNER JOIN Atores ON Atores.Id = ElencoFilme.IdAtor
