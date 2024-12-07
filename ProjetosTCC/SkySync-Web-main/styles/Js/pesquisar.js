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