<?php

	ini_set('default_charset','UTF-8');
	
	header("Access-Control-Allow-Origin: *");
	header("Access-Control-Allow-Headers: Content-Type");
	
    include('conexao.php'); 

    $user = $_GET['usuario'];
    $pass = $_GET['senha'];
			
    try { 


		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha, array(PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8"));	
		$consulta = $conecta->prepare("SELECT * FROM tb02_login WHERE tb02_usuario = '$user' and tb02_senha = '$pass'");
		
		$consulta->execute(array()); 
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "["; 
		
		if (!count($resultadoDaConsulta) ) {
			$StringJson .= '{"tb02_usuario":"vazio"}]';
			echo($StringJson);
		}
						
	    if ( count($resultadoDaConsulta) ) {
		  foreach($resultadoDaConsulta as $registro) 
		  { 
			if ($StringJson != "[") 
				{$StringJson .= ",";}
			
			$StringJson .= '{"tb02_nome":"' . $registro['tb02_nome']  . '",';	
			$StringJson .= '"tb02_usuario":"' . $registro['tb02_usuario']    . '",';		
			$StringJson .= '"tb02_senha":"' . $registro['tb02_senha'] . '"}';
			
		    }  
		echo $StringJson . "]"; 
        } 
 
	} catch(PDOException $e) { // caso retorne erro

		echo('Deu erro: ' . $e->getMessage()); 
	}
?>