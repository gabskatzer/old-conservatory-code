select p.Nombre, e.Tipo, cr.NombreCurso, rn.Nota, cr.Nivel, c.Periodo, c.Ano,   p.Estado
from Estudiante e
inner join Persona p 
on p.IdPersona = e.IdEstudiante
inner join RegistroNota rn
on e.IdEstudiante = rn.IdEstudiante
inner join Clase c 
on c.IdClase = rn.IdClase
inner join Curso cr
on cr.IdCurso = c.IdCurso
where e.IdEstudiante = 8;

select total = (select count(*) from Estudiante),
		activos = (select count(*) from Estudiante e inner join Persona p on p.IdPersona = e.IdEstudiante where p.Estado = 1),
		inactivos = (select count(*) from Estudiante e inner join Persona p on p.IdPersona = e.IdEstudiante where p.Estado = 0)
;


select p.IdPersona, p.Nombre, mat.matricula, men.mensualidad, men.multa
from Estudiante e
inner join Persona p
on p.IdPersona = e.IdEstudiante
left join (
	select p.IdPersona, matricula = sum(mat.monto)
	from Estudiante e
	inner join Persona p
	on p.IdPersona = e.IdEstudiante
	left join PagoMatricula mat
	on p.IdPersona = mat.IdEstudiante
	group by p.IdPersona
) mat
on p.IdPersona = mat.IdPersona
left join (
	select p.IdPersona, mensualidad = sum(men.monto), multa = sum(men.multa)
	from Estudiante e
	inner join Persona p
	on p.IdPersona = e.IdEstudiante
	left join PagoMensualidad men
	on p.IdPersona = men.IdEstudiante
	group by p.IdPersona
) men
on p.IdPersona = men.IdPersona;
