SELECT alunos.Aluno, cursos.Curso,professores.Professor, matriculas.Data_Matricula
FROM matriculas
JOIN alunos ON matriculas.aluno_id = alunos.id
JOIN cursos ON matriculas.curso_id = cursos.id
JOIN professores on matriculas.professor_id = professores.id;
