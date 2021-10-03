function cadastrar() {
    let error = false;
    let verificar = status ("id_placadoveiculo",'Placa');
    if (!verificar) 
    {error = true;}

    verificar = status ("id_cpfdoproprietario",'CPF');
    if (!verificar) 
    {error = true;}

    function status (formulario, nome) {
        if (($('#'+ formulario).val()== null) || ($('#'+ formulario).val() =='') ){
            formulario.className = 'vermelho';
            alert('Preencha o Campo '+ nome);
            return false;
        }
        else {
            alert('Campo Preenchido')
            return true;
    }

    
    
    }
}