
	  // The width and height of the captured photo. We will set the
	  // width to the value defined here, but the height will be
	  // calculated based on the aspect ratio of the input stream.

	  var width = 160;    // We will scale the photo width to this
	  var height = 0;     // This will be computed based on the input stream

	  // |streaming| indicates whether or not we're currently streaming
	  // video from the camera. Obviously, we start at false.

	  var streaming = false;

	  // The various HTML elements we need to configure or control. These
	  // will be set by the startup() function.

	  var video = null;
	  var canvas = null;
	  var photo = null;
	  var startbutton = null;
	  var url = null;
	  var data = null;
	  

 function startup() {
	  
    video = document.getElementById('video');
    canvas = document.getElementById('canvas');
    photo = document.getElementById('photo');
    startbutton = document.getElementById('startbutton');

    navigator.mediaDevices.getUserMedia({video: true, audio: false})
    .then(function(stream) {
      video.srcObject = stream;
      video.play();
    })
    .catch(function(err) {
      console.log("An error occurred: " + err);
    });

    video.addEventListener('canplay', function(ev){
      if (!streaming) {
        height = video.videoHeight / (video.videoWidth/width);
      
        // Firefox currently has a bug where the height can't be read from
        // the video, so we will make assumptions if this happens.
      
        if (isNaN(height)) {
          height = width / (4/3);
        }
      
        video.setAttribute('width', width);
        video.setAttribute('height', height);
        canvas.setAttribute('width', width);
        canvas.setAttribute('height', height);
        streaming = true;
      }
    }, false);

    startbutton.addEventListener('click', function(ev){
      takepicture();
      ev.preventDefault();
    }, false);
    
    clearphoto();
  }

  // Fill the photo with an indication that none has been
  // captured.

  function clearphoto() {
    var context = canvas.getContext('2d');
    context.fillStyle = "#AAA";
    context.fillRect(0, 0, canvas.width, canvas.height);

    var data = canvas.toDataURL('image/png');
    photo.setAttribute('src', data);
  }
  
  // Capture a photo by fetching the current contents of the video
  // and drawing it into a canvas, then converting that to a PNG
  // format data URL. By drawing it on an offscreen canvas and then
  // drawing that to the screen, we can change its size and/or apply
  // other changes before drawing it.

  function takepicture() {
    var context = canvas.getContext('2d');
    if (width && height) {
      canvas.width = width;
      canvas.height = height;
      context.drawImage(video, 0, 0, width, height);
    
      data = canvas.toDataURL('image/png');
      photo.setAttribute('src', data);
		// olha que barbada, o canvas tem um método toBlob!
		canvas.toBlob(function(blob){
        url = URL.createObjectURL(blob)
        // podemos usar esta URL em um elemento de vídeo, ou fazer upload do blob, etc.
        // e então, não precisamos mais da câmera
		}, 'image/png', 0.95)
    }
	else
	{
      clearphoto();
    }
  }

function atividades(chapa)
{

   // conecta ao servidor
    var xmlhttp = new XMLHttpRequest();

    //Prepara link para acionar PHP
	
    var url = "http://estudiooca.arq.br/php/consultaQRcode.php?chapa=" + chapa;
	//var url = "http://localhost:8080/php/consultaQRcode.php?chapa=" + chapa;	
	
    xmlhttp.onreadystatechange = function () 
	{
		
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200)
		{
			ConectaServidor(xmlhttp.responseText);
		}
	}
	
    xmlhttp.open("GET", url, true);
	xmlhttp.send();
		
	var foto = '<div style="text-align:center">';							  
		foto += '<a  href="#"><img src="imgs/Foto' + chapa + '.jpg" width="30%"></a>';
		foto += '</div>';	
		
	document.getElementById('fto').innerHTML =  foto;
	
	function ConectaServidor(response) {
		 
		var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
		var i=0;
		var conteudo1;
		var conteudo2;
		conteudo2 = '<div>';	

		
		// O for() vai montar a linha (<TR>) da tabela
		for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
		{
			if (dados[i].tb02_nome == "vazio")
			{
				alert("Funcionario não cadastrado");
				return;

			}
			else
			{	
				if  (i==0)
				{
					conteudo1 = '<div>';
					conteudo1 += '<h5 style="line-height: 1px;"> Chapa  : ' + dados[i].tb02_chapa +'</h5>';
					conteudo1 += '<h5 style="line-height: 1px;">' + dados[i].tb02_nome +'</h5>';
					conteudo1 += '<h5 style="line-height: 1px;">' + dados[i].tb02_funcao +'</h5></div>';
				}
							
				conteudo2 += '<h3 style="line-height: 5px;">'+ dados[i].tb03_descricao +'</h3>';
				
				var nros = dados[i].tb03_dt_venci.split('-');
				var novadata = nros[2] + "/" +nros[1]+"/"+nros[0];
				data_ok = new Date(novadata);			
				
				conteudo2 += '<h5 style="line-height: 5px;">Vencimento:'+ novadata +'</h5>';
				
				nros = dados[i].tb03_dt_treina.split('-');
				novadata = nros[2] + "/" +nros[1]+"/"+nros[0];
				data_ok = new Date(novadata);
				
				conteudo2 += '<h5 style="line-height: 5px;">Treinamento:'+ novadata +'</h5>';	
				
			}
		}
		
		document.getElementById('quem').innerHTML =  conteudo1;	
		
		conteudo2 += '</div>';
		document.getElementById('rela').innerHTML =  conteudo2;
				
	}

}
	
function geraCracha()
{

	document.getElementById('qrcode').innerHTML =  "";

	var qrcode = new QRCode("qrcode", {
	width : 100,
	height : 100
	
	});
	
	var logo='<img style="" src="imgs/rota.jpg" class="img-rounded" width="100" height="100">';
	var texto='<br><br><p style="font-weight: bold"> Válido Somente em Serviço </p><p>O portador deste crachá realizou os exames médicos e o treinamento necessário para:</p>';
	    texto+='<br><p style="font-weight: bold"> Trabalho em Altura </p><p>O trabalhador está ciente dos procedimentos de segurança a serem seguidos.</p>';
		texto+='<br><p style="font-weight: bold; color:red;"> Treinamento válido por 02 anos.</p><br><p>Em caso de Extravio procurar o setor de Segurança do Trabalho</p>';
			
	//	var foto='imgs/foto33065.jpg';
	//  photo.setAttribute('src', foto);
	
	var ra = document.getElementById('reg').value;
	var func = document.getElementById('func').value;
	var nome = document.getElementById('nome').value;
	var apto = document.getElementById('apto').value;
	var venc = document.getElementById('venc').value;
	var trei = document.getElementById('trei').value;
	
	document.getElementById('log').innerHTML =  logo;
	document.getElementById('nom').innerHTML =  nome;
	document.getElementById('fun').innerHTML =  func;
	
	//qrcode.makeCode('estudiooca.arq.br/index1.php?chapa=' + document.getElementById('reg').value);
	
	qrcode.makeCode('Chapa: ' + ra  + '\n' + 'Apto a: ' + apto + '\n' + 'Treinamento em: ' + trei + '\n' + 'Vencimento em: ' + venc);
	
	document.getElementById('fone').innerHTML =  "Emergência: 0800 770 80 70";
	document.getElementById('texto').innerHTML =  texto;
	
}

function geraPDF() {
        
		var doc = document.getElementById('cracha').innerHTML;
		
        var style = "<style>";	
		
			style = style + "body {";
			style = style + "background: #FFFFE2;";
			style = style + "border: 2px solid #bbb;";
			style = style + "margin-top: 10px;";
			style = style + "margin-bottom: 10px;";
			style = style + "margin-left: 40px;";
			style = style + "padding: 20px;";
			style = style + "text-align: center;";
			style = style + "display: block;";
			style = style + "border-radius: 10px;";
	        style = style + "-moz-border-radius: 20px;";
	        style = style + "-webkit-border-radius: 20px;";
	        style = style + "width: 300px;";
			style = style + "height: 520px;}";
			
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

