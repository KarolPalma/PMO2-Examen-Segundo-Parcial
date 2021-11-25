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
		$rneAlumno = $_GET["rneAlumno"];
		$sql="select * from tbl_alumno where alumno_rne = '" . $rneAlumno . "';"; 


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