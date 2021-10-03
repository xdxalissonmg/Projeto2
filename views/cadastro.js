function cadastrar() {
    let error = false;
    let verificar = status ("id_proprietario",'Proprietario');
    if (!verificar) 
    {error = true;}

    verificar = status ("id_fabricacao", 'Fabricacao');
    if (!verificar) 
    {error = true;}

    verificar = status ("id_data", 'Data');
    if (!verificar) 
    {error = true;}

    verificar = statusOpcionais (id_opcionais, 'Opcionais')
    if (!verificar) 
    {error = true;}
    


    function status (formulario, nome) {
        if (($('#'+ formulario).val()== null) || ($('#'+ formulario).val() =='') ){
            $('formulario').attr('background-color', 'vermelho')
            alert('Preencha o Campo '+ nome);
            return false;
        }
        else {
            alert('Campo Preenchido')
            return true;
    }
    
    }
    function statusOpcionais (formulario, nome)   
    {
        if ($(formulario).is(':checked'))
        {return true;}
        alert ('Preencha o Campo '+ nome);
        return false;
    }  
    
    
    
}