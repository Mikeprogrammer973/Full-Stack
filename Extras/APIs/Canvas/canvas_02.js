		
		/*function iniciar(){
			var el = document.getElementById("lenco");
			lenco = el.getContext("2d");
			
			var img = new Image();
			img.src = "icon.png";
			
			/*img.addEventListener("load", function(){
				//lenco.drawImage(img, 20, 20);	
				//lenco.drawImage(img, 0, 0, el.width, el.height);
				lenco.drawImage(img, 200, 100, 100, 100, 0, 0, 300, 300);
			}, false);
			
			img.addEventListener("load", mudaImagem, false);
		}
		
		function mudaImagem(e){
			img = e.target;
			/*lenco.drawImage(img, 0, 0);
			var info = lenco.getImageData(0, 0, 200, 200);
			
			var pos;
			
			for(var x = 0; x <= 200; x++){
				for(var y = 0; y <= 200; y++){
					pos = (info.width*4*y) + (x*4);
					info.data[pos] = 255 - data[pos];
					info.data[pos+1] = 255 - data[pos+1];
					info.data[pos+2] = 255 - data[pos+2];
				}
			}
			lenco.putImage(info, 0, 0);
			
			var personal = lenco.createPattern(img, 'repeat-x');
			lenco.fillStyle = personal;
			lenco.fillRect(0, 0, 468, 400);
		}
		
		window.addEventListener("load", iniciar, false);*/

			function iniciar(){
		 var elemento = document.getElementById('lenco');
		 lenco = elemento.getContext('2d');
		 window.addEventListener('mousemove', animacao, false);
	}
	function animacao(e){
		 lenco.clearRect(0,0,300,500);
		 
		 var xraton = e.clientX;
		 var yraton = e.clientY;
		 var xcentro = 220; 		
		 var ycentro = 150;
		 
		 var angulo = Math.atan2(xraton-xcentro,yraton-ycentro);
		 var x = xcentro+Math.round(Math.sin(angulo)*10);
		 var y = ycentro+Math.round(Math.cos(angulo)*10);
		 
		 lenco.beginPath();
		 lenco.arc(xcentro,ycentro,20,0,Math.PI*2, false);
		 lenco.moveTo(xcentro+70,150);
		 lenco.arc(xcentro+50,150,20,0,Math.PI*2, false);
		 lenco.stroke();
		 lenco.beginPath();
		 lenco.moveTo(x+10,y);
		 lenco.arc(x,y,10,0,Math.PI*2, false);
		 lenco.moveTo(x+60,y);
		 lenco.arc(x+50,y,10,0,Math.PI*2, false);
		 lenco.fill();
	}
	window.addEventListener("load", iniciar, false);