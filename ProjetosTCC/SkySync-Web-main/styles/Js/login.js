document.getElementById('btn-login').onclick = function() {

    const txtBemVindo = document.getElementById('bem-vindo');
    const btnLogin = document.getElementById('btn-login');
    const txtCriaSuaConta = document.getElementById('crie-sua-conta');
    const btnCriar = document.getElementById('btn-criar');
    const campoNome = document.getElementById('campo-nome');
    const formulario = document.getElementById('container-form');
    const iconePersona = document.getElementById('icon-persona');

    if(txtBemVindo.innerText == 'Bem-vindo de Volta!') {
        txtCriaSuaConta.innerText = 'Fazer Login'
        txtBemVindo.innerText = 'Não tem conta ainda?';
        btnLogin.innerText = 'Criar Conta'; 
        btnCriar.innerText = 'Entrar';
        campoNome.style.display = 'none';
        formulario.style.marginTop = '-1.9vw';
        iconePersona.style.display = 'none';
    } else {
        txtCriaSuaConta.innerText = 'Crie sua Conta'
        txtBemVindo.innerText = 'Bem-vindo de Volta!';
        btnLogin.innerText = 'Fazer Login';
        btnCriar.innerText = 'Criar Conta';
        campoNome.style.display = 'inline-block';
        formulario.style.marginTop = '0vw';
        iconePersona.style.display = 'inline-block';
    }
}