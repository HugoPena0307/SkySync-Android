const div_clique = document.getElementById('pop-conectar-mensagem');
const div_chatBot = document.getElementById('chat-bot-aba');
const div_conectar = document.getElementById('div-clique');
const div_conectar_all = document.getElementById('pop-conectar');
const btn_sair = document.getElementById('btn-sair-chatbot')

div_clique.addEventListener('click', () => {
    div_clique.style.display = 'none';
    div_conectar_all.display = 'none';
    div_conectar.style.display = 'none';
    if (div_chatBot.classList.contains('escondido')) {
        div_chatBot.classList.remove('escondido');
        div_chatBot.classList.add('visivel');
    } else {
        div_chatBot.classList.remove('visivel');
        div_chatBot.classList.add('escondido');
    }
});

div_conectar.addEventListener('click', () => {
    div_conectar.style.display = 'none';
    div_conectar_all.style.display = 'none';
    div_clique.style.display = 'none';
    if (div_chatBot.classList.contains('escondido')) {
        div_chatBot.classList.remove('escondido');
        div_chatBot.classList.add('visivel');
    } else {
        div_chatBot.classList.remove('visivel');
        div_chatBot.classList.add('escondido');
    }
});

btn_sair.addEventListener('click', () => {
    div_clique.style.display = 'flex';
    if (div_chatBot.classList.contains('escondido')) {
        div_chatBot.classList.remove('escondido');
        div_chatBot.classList.add('visivel');
    } else {
        div_chatBot.classList.remove('visivel');
        div_chatBot.classList.add('escondido');
    }
});

document.getElementById('close-conectar').onclick = function() {
    document.getElementById('pop-conectar').style.display = 'none';
}

document.getElementById('pesquisar').onclick = function() {

    const div_pesquisar = document.getElementById('pesquisar-caixa');
    document.getElementById('menu-icon').style.marginLeft = '0.01vw';
    document.getElementById('containerHeader').style.justifyContent = 'left';
    document.getElementById('pesquisar').style.display = 'none';
    document.getElementById('entrar').style.display = 'none';
    document.getElementById('sobre-nos').style.display = 'none';
    document.getElementById('mecanica').style.display = 'none';
    div_pesquisar.classList.remove('escondido');
    div_pesquisar.style.display = 'flex';
}

document.getElementById('cancelar-pesquisa').onclick = function() {

    const div_pesquisar = document.getElementById('pesquisar-caixa');
    const caixaPesquisar = document.getElementById('caixa-de-pesquisa');

    document.getElementById('containerHeader').style.justifyContent = 'center';
    document.getElementById('menu-icon').style.marginLeft = '-0.01vw';
    document.getElementById('pesquisar').style.display = 'block';
    document.getElementById('entrar').style.display = 'flex';
    document.getElementById('sobre-nos').style.display = 'block';
    document.getElementById('mecanica').style.display = 'block';
    div_pesquisar.classList.add('escondido');
    div_pesquisar.style.display = 'none';
    caixaPesquisar.value = '';
}
