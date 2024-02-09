function createProduto(){
    const produtoID =document.getElementById("produtoID").value;
    const NomeProduto = document.getElementById ("NomeProduto").value;
    const Descricao = document.getElementById("Descricao").value;
    const categoria = document.getElementById("categoria").value;
    const QuantidadeDisponivelParaDoacao = document.getElementById("QuantidadeDisponivelParaDoacao" ).value;
    const DoadorId=document.getElementById("DoadorId").value;
   
    const data={
        produtoID:produtoID,
        NomeProduto:NomeProduto,
            Descricao:Descricao,
           categoria:categoria,
           QuantidadeDisponivelParaDoacao :QuantidadeDisponivelParaDoacao,
           DoadorId:DoadorId
         

    }
    

fetchDoador('https://localhost:7235/api/Produto/Create', {
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