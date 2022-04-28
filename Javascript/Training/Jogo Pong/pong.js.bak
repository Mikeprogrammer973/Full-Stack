// Elementos
var btn_iniciar;
var barra_cpu;
var barra_player;
var bola;
var txt_pontos;

// Controle de animação
var jogo;
var frames;

// Posições

var pos_bolaX, pos_bolaY;
var pos_playerX, pos_playerY;
var pos_cpuX, pos_cpuY;

// Direção teclas
var dir_playerY;
var dir_playerX;

// Posições iniciais
var pos_ini_playerX = 20, pos_ini_playerY = 150;
var pos_ini_cpuX = 680, pos_ini_cpuY = 150;
var pos_ini_bolaX = 320, pos_ini_bolaY = 170;

// Tamanhos
var campoX = 0, campoY = 0, campo_width = 700, campo_height = 400;
var barra_width = 15, barra_height = 100;
var bola_width = 30, bola_height = 30;

// Direção
var bolaX, bolaY;
var cpuY = 0;

// Velocidade
var vel_bola, vel_cpu, vel_player;

// Controle
var pontos = 0;
var tecla;
var game = false;

// Config. modos
var player1_player2 = false;
var player1_onlineplayer = false;
var player1_cpu = true;

function controle_player(){
    if(game){
        pos_playerY += dir_playerY*vel_player;
		pos_playerX += dir_playerX*vel_player;
        if((pos_playerY + barra_height) >= (campo_height + 10) || (pos_playerY) <= 10){
            pos_playerY += (dir_playerY*vel_player) * (-1);			
        } 
		if(pos_playerX >= (campo_width/2) || (pos_playerX) <= 10){
			pos_playerX += (dir_playerX*vel_player) * (-1);
			}		
        barra_player.style.top = pos_playerY + "px";
		barra_player.style.left = pos_playerX + "px";
    }
}

function controle_cpu(){
	if(game){
		if((pos_bolaX > (campo_width / 2)) && (bolaX > 0)){
			// Movimentação da CPU
			if((pos_bolaY + (bola_height/2)) > ((pos_cpuY + (barra_height/2)) + vel_cpu)){
				// Mover para baixo
				if((pos_cpuY + barra_height) <= campo_height){
					pos_cpuY += vel_cpu;
				}
			}else if((pos_bolaY + (bola_height/2)) < ((pos_cpuY + (barra_height/2)) - vel_cpu)){
				// Mover para cima
				if(pos_cpuY >= 0){
					pos_cpuY -= vel_cpu;
				}
			}
		}else{
			// Posiciar CPUU no centro
			pos_cpuY  = pos_ini_cpuY;			
		}
		barra_cpu.style.top = pos_cpuY + "px";
	}
}


function controle_bola(){
	
	pos_bolaX += vel_bola*bolaX;
	pos_bolaY += vel_bola*bolaY;
	
	// cloisão com o  player 1 (jogador)
	if((pos_bolaX <= pos_playerX + barra_width) && ((pos_bolaY + bola_height) >= pos_playerY) && (pos_bolaY <= pos_playerY + barra_height)){
		bolaY = (((pos_bolaY + (bola_height / 2)) - (pos_playerY + (barra_height / 2))) / 16);
		bolaX *= -1;
	}
	
	// cloisão com o  player 2 (cpu)
	if((pos_bolaX >= pos_cpuX + (barra_width -40)) && ((pos_bolaY + bola_height) >= pos_cpuY) && (pos_bolaY <= pos_cpuY + barra_height)){
		bolaY = (((pos_bolaY + (bola_height / 2)) - (pos_cpuY + (barra_height / 2))) / 16);
		bolaX *= -1;
	}
	
	//Limites superior e inferior
	if(pos_bolaY >= 390 || pos_bolaY <= 10){
		bolaY *= -1;
	}
	
	//Limites direita e esquerda
	if(pos_bolaX <= bola_width - 10){
		bolaX *= -1;
		pontos -= 1;
		game = false;
		pos_bolaX = pos_ini_bolaX;
        pos_bolaY = pos_ini_bolaY;
		setTimeout(iniciar_game, 1000);
	}
	if(pos_bolaX >= (campo_width - bola_width)){
		bolaX *= -1;
		pontos += 1;
		game = false;
		pos_bolaX = pos_ini_bolaX;
        pos_bolaY = pos_ini_bolaY;
		setTimeout(iniciar_game, 1000);
	}
	txt_pontos.value = pontos;
	bola.style.top = pos_bolaY + "px";
	bola.style.left = pos_bolaX + "px";
}

function tecla_down(e){
    var cod_tecla = e.keyCode;
    if(cod_tecla == 38){// cima
        dir_playerY = -1;
    }else if(cod_tecla == 40){// baixo
        dir_playerY = 1;
    }else if(cod_tecla == 37){// esquerda
        dir_playerX = -1;
    }else if(cod_tecla == 39){// direita
        dir_playerX = 1;
    }
}

function tecla_up(e){
    var cod_tecla = e.keyCode;
    if(cod_tecla == 38){// cima
        dir_playerY = 0;
    }else if(cod_tecla == 40){// baixo
        dir_playerY = 0;
    }else if(cod_tecla == 37){// esquerda
        dir_playerX = 0;
    }else if(cod_tecla == 39){// direita
        dir_playerX = 0;
    }
}

function controle_game(){
    if(game){
		controle_cpu();
        controle_player();
		controle_bola();		
    }
    frames = requestAnimationFrame(controle_game);
}

function iniciar_game(){
    if(!game){
        cancelAnimationFrame(frames);
        game = true;
		bolaY = 0;
		if((Math.random()*10) < 5){
			bolaX = -1;
		}else{
			bolaX = 1;
		}
        dir_playerY = 0;
        pos_bolaX = pos_ini_bolaX;
        pos_bolaY = pos_ini_bolaY;
        pos_cpuX = pos_ini_cpuX;
        pos_cpuY  = pos_ini_cpuY;
        pos_playerX = pos_ini_playerX;
        pos_playerY = pos_ini_playerY;
        controle_game();
    }      
}

function inicializar(){ 
    vel_player = 8;
    vel_cpu = 8;
    vel_bola = 5;
    btn_iniciar = document.getElementById("init_btn");
    btn_iniciar.addEventListener("click", stop_game);
    barra_cpu = document.getElementById("cpu");
    barra_player = document.getElementById("player");
    bola = document.getElementById("bola");
    txt_pontos = document.getElementById("pts");
    document.addEventListener("keydown", tecla_down);
    document.addEventListener("keyup", tecla_up);
}

function stop_game(){
	if(btn_iniciar.innerHTML == "Iniciar"){
		btn_iniciar.innerHTML = "Parar";
		iniciar_game();
	}else if(btn_iniciar.innerHTML == "Parar"){
		btn_iniciar.innerHTML = "Reiniciar";
		game = false;
	}else if(btn_iniciar.innerHTML == "Reiniciar"){
		btn_iniciar.innerHTML = "Parar";
		iniciar_game();
	}
}

window.addEventListener("load", inicializar);