		
		function iniciar(){
			var el = document.getElementById("lenco");
			lenco = el.getContext("2d");
			
			//lenco.fillStyle = "#000099";
			//lenco.strokeStyle = "#990000";
			
			/*var gradiente = lenco.createLinearGradient(0,0,10,100);
			var gradiente_2 = lenco.createRadialGradient(0,0,30,0,0,300)
			gradiente_2.addColorStop(0.5, 'gray');
			gradiente_2.addColorStop(1, 'green');
			lenco.fillStyle= gradiente_2; 
			
			lenco.strokeRect(100, 100, 120, 120);
			lenco.fillRect(110, 110, 100, 100);
			lenco.clearRect(120, 120, 80, 80);*/
			
			/*lenco.beginPath();
			//Traçado
			lenco.moveTo(100,100);
			lenco.lineTo(200,200);
			lenco.lineTo(100,200);
			//lenco.fill();
			lenco.closePath();
			lenco.stroke();*/
			/*
			lenco.beginPath();
			lenco.moveTo(100,100);
			lenco.lineTo(700,700);
			lenco.lineTo(100,700);
			lenco.clip();
			
			lenco.beginPath();
			
			for(f = 0; f < 300; f += 10){
				lenco.moveTo(0,f);
				lenco.lineTo(500, f);
			}
			lenco.stroke();*/
			
			
			//Curvas e círculos
			
			/*lenco.beginPath();
			//O centro está na posição (200, 200), tem um raio de 100px, começa de 0° e vai até 360°
			lenco.arc(200, 200, 100, 0, Math.PI*2, false);// Math.PI*2 = 360° em radianos e Math.PI = 180°                                              
			lenco.stroke();*/
			
			/*lenco.beginPath();
			// Calculando valor em radiano de um ângulo de 45°
			var radiano = Math.PI/180*45;
			lenco.arc(200, 200, 70, 0, radiano, true);
			lenco.stroke();*/
			
			/*lenco.beginPath();
			lenco.moveTo(50, 50);
			lenco.quadraticCurveTo(120, 100, 50, 200);
			lenco.stroke();
			lenco.moveTo(250, 50);
			lenco.bezierCurveTo(100, 12, 200, 300, 250, 200);
			lenco.stroke();*/
			
			/*lenco.lineWidth=10;
			lenco.lineCap = "square";
			lenco.beginPath();
			lenco.moveTo(230, 150);
			lenco.arc(200, 150, 30, 0, Math.PI, false);
			lenco.stroke()
			
			lenco.lineWidth=5;
			lenco.lineJoin="miter";
			lenco.miterLimit = 3;
			lenco.beginPath();
			lenco.moveTo(195,135);
			lenco.lineTo(215,155);
			lenco.lineTo(195,155);
			lenco.stroke(); */
			
			// Textos
			
			lenco.beginPath();
			
			lenco.shadowColor = "rgb(0, 0, 0, 0.434)";
			lenco.shadowOffsetX = 5;
			lenco.shadowOffsetY = 5;
			lenco.shadowBlur = 2;
			
			lenco.font = "bold 1.5em algerian, serif";
			lenco.textAlign = "start";
			//lenco.textBaseline = "bottom"
			/*lenco.fillText("Ok!", 50, 20);
			lenco.translate(50, 70);
			lenco.rotate(Math.PI/180*45);
			lenco.fillText("OK!", 0, 0);
			lenco.rotate(-Math.PI/180*45);
			lenco.translate(0, 100);
			lenco.scale(3,3);
			lenco.fillText("OK!", 0, 0);*/
			/*
			lenco.strokeText("Que assim seja, Amém!", 100, 145);
			
			var tam = lenco.measureText("Que assim seja, Amém!");
			lenco.strokeRect(100, 120, tam.width, 25);
			*/
			/*lenco.save();
			
			//lenco.strokeText("Amém!", 20, 20)
			lenco.transform(3,1,2,7,-120,2); 
			lenco.font = "bold 1.5em algerian, serif";
			lenco.strokeText("Amém!",80, 20)
			lenco.setTransform(1,0,0,10,0,0); 
			
			lenco.restore();
			
			lenco.strokeText("Amém!",300, 20);*/
			
			lenco.fillStyle="#990000";
			lenco.fillRect(100,100,300,100);
			lenco.globalCompositeOperation="destination-out";
			lenco.fillStyle="#AAAAFF";
			lenco.font="bold 80px verdana, sans-serif";
			lenco.textAlign="center";
			lenco.textBaseline="middle";
			lenco.fillText("TESTE",250,145); 
			
			
			
		}
		
		window.addEventListener("load", iniciar, false);
