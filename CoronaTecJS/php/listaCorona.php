<?php

	ini_set('default_charset','UTF-8');
	
	header("Access-Control-Allow-Origin: *");
	header("Access-Control-Allow-Headers: Content-Type");
	
    include('conexao.php'); 
			
    try { 

		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha, array(PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8"));	
		$consulta = $conecta->prepare("SELECT * FROM tb01_corona;");
		
		$consulta->execute(array()); 
		$resultadoDaConsulta = $consulta->fetchAll();
 
		$StringJson = "["; 
		
		if (!count($resultadoDaConsulta) ) {
			$StringJson .= '{"tb01_nome":"vazio"}]';
			echo($StringJson);
		}
						
	    if ( count($resultadoDaConsulta) ) {
		  foreach($resultadoDaConsulta as $registro) 
		  { 
			if ($StringJson != "[") 
				{$StringJson .= ",";}
			
			$StringJson .= '{"tb01_nome":"' . $registro['tb01_nome']  . '",';
//			$StringJson .= '"tb02_nome":"' . $registro['tb02_nome']  . '",';				
//			$StringJson .= '"tb02_funcao":"' . $registro['tb02_funcao']  . '",';	
//			$StringJson .= '"tb03_descricao":"' . $registro['tb03_descricao']    . '",';	
			$StringJson .= '"tb01_nacionalidade":"' . $registro['tb01_nacionalidade']    . '",';		
			$StringJson .= '"tb01_idade":"' . $registro['tb01_idade'] . '"}';
			
		    }  
		echo $StringJson . "]"; 
        } 
 
	} catch(PDOException $e) { // caso retorne erro

		echo('Deu erro: ' . $e->getMessage()); 
	}
?>