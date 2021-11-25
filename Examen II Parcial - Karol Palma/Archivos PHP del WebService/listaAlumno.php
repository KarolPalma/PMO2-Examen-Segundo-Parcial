<?php
include("conexion.php");
	if(!$bdcon)
	{
		echo "Lo sentimos, este sitio web esta experimentando problemas";
		exit;
	}
	else 
	{
		$datos=array();
		//$sql="select * from tbl_user";
		$aniolAnio = $_GET["aniolAnio"];
		$sql="select * from tbl_alumno as a inner join tbl_historial h on a.alumno_rne = h.alumno_rne where h.aniol_anio = '" . $aniolAnio . "' and h.grado_codigo = 1 ORDER BY a.alumno_genero, a.alumno_nombre1 ASC;";

		//$sql="select a.alumno_rne, concat(a.alumno_nombre1 ,' ', a.alumno_nombre2,' ', a.alumno_ape1, ' ', a.alumno_ape2) as nombre, a.alumno_genero, h.grado_codigo from tbl_alumno as a inner join tbl_historial h on a.alumno_rne = h.alumno_rne where h.aniol_anio = '" . $aniolAnio . "' and h.grado_codigo = 1;";

		$result=mysqli_query($conexion,$sql);
		while($row=mysqli_fetch_assoc($result))
		{
			array_push($datos,array(
				'alumno_rne'=>$row["alumno_rne"],
				'alumno_nombre1'=>$row["alumno_nombre1"],
				'alumno_nombre2'=>$row["alumno_nombre2"],
				'alumno_ape1'=>$row["alumno_ape1"],
				'alumno_ape2'=>$row["alumno_ape2"],
				'alumno_genero'=>$row["alumno_genero"],
				'alumno_fnac'=>$row["alumno_fnac"],
			));
		}


		echo utf8_encode(json_encode($datos));
	}
?>