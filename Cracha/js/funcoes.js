function testacampo(){
	var ta = document.getElementById("reg").value;
	var empresa = document.getElementById("empresa").value;
	var nome = document.getElementById("nome").value;
	var CPF = document.getElementById("CPF").value;
	var fun = document.getElementById("func").value;
	var apto = document.getElementById("apto").value;
	var treinamento = document.getElementById("trei").value;
	var vencimento = document.getElementById("venc").value;

	if(ta == '' ||
	   empresa == '' ||
	   nome == '' ||
	   CPF == '' ||
	   fun == '' ||
	   apto == '' ||
	   treinamento == '' ||
	   vencimento == ''){
		   alert("PREENCHA TODOS OS CAMPOS CORRETAMENTE");
	   }
	   else{
		   alert("Dados Registrados!");

		   console.log(ta);
		   console.log(empresa);
		   console.log(nome);
		   console.log(CPF);
		   console.log(fun);
		   console.log(apto);
		   console.log(treinamento);
		   console.log(vencimento);

		   geraCracha();
	   }
}


function geraPDF() {
        
		var doc = document.getElementById('cracha').innerHTML;
		
        var style = "<style>";	
		
			style = style + "body {";
			style = style + "background: White;";
			style = style + "border: 2px solid #bbb;";
			style = style + "margin-top: 10px;";
			style = style + "margin-bottom: 10px;";
			style = style + "margin-left: 10px;";
			style = style + "padding: 20px;";
			style = style + "text-align: center;";
			style = style + "display: block;";
			style = style + "border-radius: 10px;";
	        style = style + "-moz-border-radius: 20px;";
	        style = style + "-webkit-border-radius: 20px;";
	        style = style + "width: 600px;";
			style = style + "height: 820px;}";
			
			style = style + ".output{text-align: center;}";
			style = style + ".logo{text-align: center}";
			style = style + ".nome{font-size: 40px}";		
			style = style + ".func{font-size: 36px}";		
			style = style + ".qcode{margin-left: 8%;}";
		
        style = style + "</style>";
		
        // CRIA UM OBJETO WINDOW
        var win = window.open('', '', 'height=700,width=700');
        win.document.write('<html><head>');
        win.document.write('<title>Cracha Funcional</title>');   // <title> CABEÇALHO DO PDF.
        win.document.write(style);                                     // INCLUI1 UM ESTILO NA TAB HEAD
        win.document.write('</head>');
        win.document.write('<body>');
        win.document.write(doc);                          // O CONTEUDO DA TABELA DENTRO DA TAG BODY
        win.document.write('</body></html>');
        win.document.close(); 	                                         // FECHA A JANELA
        win.print();                                                            // IMPRIME O CONTEUDO
    }

    function geraCracha()
{
	
	var logo='<img style="" src="img/eteclogo.png" class="img-rounded" width="100" height="100">';
	var texto='<br><br><p style="font-weight: bold"> Válido Somente em Serviço </p><p>O portador deste crachá realizou os exames médicos e o treinamento necessário para:</p>';
		texto+='<br><p style="font-weight: bold; color:red;"> Treinamento válido por 02 anos.</p><br><p>Em caso de Extravio procurar o setor de Segurança do Trabalho</p>';
			
	
	var ta = document.getElementById("reg").value;
	var empresa = document.getElementById("empresa").value;
	var nome = document.getElementById("nome").value;
	var CPF = document.getElementById("CPF").value;
	var fun = document.getElementById("func").value;
	var apto = document.getElementById("apto").value;
	var treinamento = document.getElementById("trei").value;
	var vencimento = document.getElementById("venc").value;
	
	document.getElementById('log').innerHTML =  logo;
	document.getElementById('nom').innerHTML =  nome;
	document.getElementById('fun').innerHTML =  fun;
	
	var conteudo = 'RA: ' + ta  + '\n' + ' Nome:' + nome + '\n' + ' Apto a: ' + apto + '\n' + ' Treinamento em: ' + treinamento + '\n' + ' Vencimento em: ' + vencimento;
    var GoogleCharts = 'https://chart.googleapis.com/chart?chs=500x500&cht=qr&chl=';
    var imagemQRCode = GoogleCharts + conteudo;
    document.getElementById('imageQRCode').src = imagemQRCode;

	document.getElementById('fone').innerHTML =  "Emergência: 0800 770 80 70";
	document.getElementById('texto').innerHTML =  texto;
	
}
