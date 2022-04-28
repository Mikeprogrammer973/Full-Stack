   var lib = ["caderno", "amizade", "frango", "carro", "macarrão", "bola", "carne", "borracha", "suco", "moto", "vinho", "bicicleta", "sistema", "lanterna", "programador", "linguagem", "mesa", "apontador", "tela", "luta", "travesseiro", "computador", "cabeça", "roupa", "cama", "caçador", "grilha", "calça", "palavra", "vento", "livro", "crema", "garoto", "cor", "caminhão", "telhado", "menina", "tomada", "perfum", "feijão", "shampoo", "fogão", "conta", "arroz", "número", "comida", "mercado", "código", "ventilador", "sabonete", "biblioteca", "botas", "universal", "pó", "régua", "copo", "esperança", "janela", "planta", "desenvolvedor", "nuvem", "sono", "céu", "terra", "jogo", "inferno", "pessoa", "humano", "salvação", "porta", "portaria", "perda", "perdição", "coração"];
   var jogo = false;
   var jog;
   var load;
   var acertos = 0;
   var erros = 0;
   var acertou = false;
   var sorte;
   var qtd = lib.length-1;
   var palavra;
   var tmp = 0;
   var status = 1;
   var desenho = [];
   var anima;
   var cor = "black";
   var victory = false
   var novo = 0;

    function pausa(){
        if(document.getElementById("pause").innerHTML == "Pausar"){            
        jogo = false;
        cancelAnimationFrame(anima);
        document.getElementById("letra").focus();
        document.getElementById("pause").innerHTML = "Continuar";
        }else if(document.getElementById("pause").innerHTML == "Continuar"){
        jogo = true;
        tempo();
        document.getElementById("letra").focus();
        document.getElementById("pause").innerHTML = "Pausar";
        }
    }

   window.addEventListener("keydown", tecla);

   function tecla(){
       if(event.keyCode == 13){
           jogar();
       }
   }
    
    function iniciar(){  
		victory = false;			
		novo = 1;				
        jogo = true; 
		acertos = 0;
		erros = 0;
        document.getElementById("word").innerHTML = " ";
        jog = document.getElementById("letra");
        sorte = Math.round(Math.random() * qtd);
        palavra = lib[sorte];
        for(var c = 0; c < palavra.length; c++){
            document.getElementById("word").innerHTML += `<button id='letra${c}' class='letra'></button>`;
        }
        document.getElementById("letra").focus();
        if(status == 1){
            tempo();
        }
    }

    function jogar(){        
        tmp = 0;
        if(jogo){
            var pos;
            var pesq;
            var letra = document.getElementById("letra").value;
            if(letra == ""){
                alert("Digite uma letra seu lerdo!");
                document.getElementById("letra").focus();
                return;
            }
            document.getElementById("letra").focus();
            acertou = false;
            pesq = palavra.match(letra);          
                while(pesq != null){
                    pos = palavra.search(letra);
                    document.getElementById("letra" + pos).innerHTML = letra.toUpperCase();
                    palavra = palavra.replace(letra, "0");
                    acertos++;
                    pesq = palavra.match(letra);
                    acertou = true;
                }                

                if(!acertou){
                    erros++;					
                    if(erros <= 6){						
                        document.getElementById(`c${erros}`).style.backgroundColor = "gray";
                        document.getElementById(`c${erros}`).innerHTML = letra.toUpperCase();
						bonecoCons();
                    }else{                        
                        for(var i = 1; i <= 6; i++){
                            document.getElementById(`c${i}`).style.backgroundColor = "green";
                            document.getElementById(`c${i}`).innerHTML = " ";
                        }
						bonecoCons();
                    }
                }

                if(acertos == palavra.length){                    
                    for(var i = 1; i <= 6; i++){
                            document.getElementById(`c${i}`).style.backgroundColor = "green";
                            document.getElementById(`c${i}`).innerHTML = " ";
                        } 
					erros = 0;
                    victory = true; 
					bonecoCons();
                }              
                           
        }       


    }

    function tempo(){    
        status = 0;    
        tmp++;
        if(tmp >= 1000){
            status = 1;
            tmp = 0;
            erros++;
             if(erros <= 6){
                        document.getElementById(`c${erros}`).style.backgroundColor = "gray";
						bonecoCons();
                    }else{
                        for(var i = 1; i <= 6; i++){
                            document.getElementById(`c${i}`).style.backgroundColor = "green";
                            document.getElementById(`c${i}`).innerHTML = " ";
                        }
                        bonecoCons();
                    }
        }
        load = tmp / 10;
        document.getElementById("bara").style.width = `${load}%`;
        
        anima = window.requestAnimationFrame(tempo);

    }

    function dica(){
        if(palavra.charAt(0) == 0){
            alert("Dica: Nenhuma dica por aí meu brother!");
            document.getElementById("letra").focus();
        }else{
            alert("Dica: " + palavra.charAt(0));
            document.getElementById("letra").focus();
        }       
    }
	

					
			function bonecoCons(){
				
				var el = document.getElementById("boneco");
				boneco = el.getContext("2d");	
				boneco.shadowColor = "rgb(0, 0, 0, 0.456)";
				boneco.shadowOffsetX = 3;
				boneco.shadowOffsetY = 3;
				boneco.shadowBlur = 1;
				boneco.globalCompositeOperation = "destination-over";
				boneco.lineWidth = 5;
				if(novo == 1){
					boneco.clearRect(0, 0, 375, 300);
					novo = 0;
				}
				if(erros == 1){
					boneco.beginPath();
					//cabeça
					boneco.arc(150, 50, 50, 0, Math.PI*2, false);
					boneco.stroke();
					boneco.closePath();
				}else if(erros == 2){
					boneco.beginPath();	
					//corpo
					boneco.moveTo(150, 290);
					boneco.lineTo(150, 100);
					
					boneco.stroke();
					boneco.closePath();
				}else if(erros == 3){
					boneco.beginPath();
					//braço_e
					boneco.moveTo(150, 115);
					boneco.lineTo(180,200);
					
					boneco.stroke();
					boneco.closePath();
				}else if(erros == 4){
					boneco.beginPath();	
					//braço_d
					boneco.moveTo(150, 115);
					boneco.lineTo(115, 200);
					
					boneco.stroke();
					boneco.closePath();
				}else if(erros == 5){
					boneco.beginPath();	
					//perna_e
					boneco.moveTo(150, 200);
					boneco.lineTo(190, 290);
					
					boneco.stroke();
					boneco.closePath();
				}else if(erros == 6){
					boneco.shadowColor = "rgb(0, 0, 0, 0.456)";
					boneco.shadowOffsetX = 3;
					boneco.shadowOffsetY = 3;
					boneco.shadowBlur = 1;
						boneco.clearRect(0, 0, 375, 300);
						boneco.beginPath();	
						
						boneco.strokeStyle = cor;			
						//cabeça
						boneco.arc(150, 60, 42, 0, Math.PI*2, false);
						//corpo
						boneco.moveTo(150, 290);
						boneco.lineTo(150, 100);
						//braço_e
						boneco.moveTo(150, 115);
						boneco.lineTo(180, 200);
						//braço_d
						boneco.moveTo(150, 115);
						boneco.lineTo(115, 200);
						//perna_e
						boneco.moveTo(150, 200);
						boneco.lineTo(190, 300);
						//perna_d
						boneco.moveTo(150, 200);
						boneco.lineTo(50, 490);
						
						boneco.stroke();
						
						boneco.closePath();
						setTimeout(piscar, 250)
				}else if(erros == 7){
					boneco.beginPath();
					boneco.clearRect(0, 0, 375, 300);
					boneco.shadowColor = "rgb(0, 0, 0, 0.456)";
					boneco.shadowOffsetX = 3;
					boneco.shadowOffsetY = 3;
					boneco.shadowBlur = 1;
					boneco.strokeStyle = "darkred";
					boneco.strokeRect(48, 48, 304, 114);
					boneco.fillStyle = "#990000";
					boneco.fillRect(50, 50, 300, 110);
					boneco.globalCompositeOperation = "destination-out";
					boneco.font = "bold 2.5em verdana, sans-serif";
					boneco.textBaseline = "bottom";						
					boneco.fillText("Game Over!", 65, 120);
					boneco.closePath();
					
					  
					erros = 0;
                    acertos = 0;
					setTimeout(luck,1000);
				}else if(victory){
					boneco.clearRect(0, 0, 375, 300);
					boneco.beginPath();
					boneco.shadowColor = "rgb(0, 0, 0, 0.456)";
					boneco.shadowOffsetX = 3;
					boneco.shadowOffsetY = 3;
					boneco.shadowBlur = 1;
					boneco.strokeStyle = "lightblue";
					boneco.strokeRect(48, 48, 304, 114);
					boneco.fillStyle = "green";
					boneco.fillRect(50, 50, 300, 110);
					boneco.globalCompositeOperation = "destination-out";
					boneco.font = "bold 2.5em verdana, sans-serif";
					boneco.textBaseline = "bottom";					
					boneco.fillText("You Win!", 100, 120);
					boneco.closePath();
					
					  
					erros = 0;
                    acertos = 0;
					setTimeout(luck,1000);
				}
			}
			
			function piscar(){				
						if(cor == "black"){
							cor = "red";
						}else if(cor == "red"){
							cor = "black";
						}
						bonecoCons();
						//setTimeout(boneco, 250);
			}
			
			function luck(){
				var el = document.getElementById("boneco");
			boneco = el.getContext("2d");			
				boneco.clearRect(0, 0, 375, 300);	
				boneco.strokeStyle = "black";
					setTimeout(iniciar, 1000);
			}
			
