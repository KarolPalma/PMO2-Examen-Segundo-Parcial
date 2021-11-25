<?php 
    $bdcon=true;
	//$conexion=new mysqli("localhost","id15185991_root","Progra-Movil2","id15185991_pw2_planilla");
	//$conexion=new mysqli("localhost","root","kp198103","colegio");
	$conexion=new mysqli("localhost","id17964736_karolpalma","Fwgw_95378856","id17964736_colegio");
	if($conexion->connect_errno)
	{
		echo "Lo sentimos, este sitio web esta experimentando problemas ".$mysqli -> error;
		//exit;
		$bdcon=false;
	}
	//else echo "Conexion Exitosa";
?>