function createDoador(){
    const NomeDoador = document.getElementById ("NomeDoador").value;
    const Cidade = document.getElementById("Cidade").value;
    const Estado = document.getElementById("Estado").value;
    const CEP = document.getElementById("CEP" ).value;
    const Email = document.getElementById("Email").value;
    const Telefone = document.getElementById("Telefone" ).value;
    

    const data={

        NomeDoador:NomeDoador,
            Cidade:Cidade,
           Estado:Estado,
           CEP:CEP,
            Email:Email,
          Telefone:Telefone,
          


    }
 console.log(data)
 
 debugger

fetch('https://localhost:7235/api/Doador/Create', {
    method:'POST',
    headers: {
        'Content-Type':'application/json'
    },
    body:JSON.stringify(data)

}).then(Response =>{
    if(!Response.ok){
        alert("erro ao criar pessoa")
    }
    alert("pessoa criada com sucesso!");
    window.location.href = '../index.html';




})
}