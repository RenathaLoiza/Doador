document.addEventListener('DOMContentLoaded', function(){
 
    const doadorLista = document.getElementById('doador-lista');
 
    function renderTable(data){
        doadorLista.innerHTML = '';
 
        data.forEach(doador => {
            const row =document.createElement('tr');
 
        row.innerHTML= `
            <td>${doador.DoadorId}</td>
            <td>${doador.NomeDoador}</td>
            <td>${doador.Cidade}</td>
            <td>${doador.Estado}</td>
            <td>${doador.CEP}</td>
            <td>${doador.Email}</td>
            <td>${doador.Telefone}</td>
            <td>
                <button>Editar</button>
                <button>Excluir</button>
 
            </td>
           
        `;
        doadorLista.appendChild(row);
           
        });
    }
 
    function feachDoador(){
      //  fetch('https://localhost:7235/api/Doador/Create')
      //  .then(response => response.json())
       // .then(data => renderTable(data))
       // .catch(error => console.error('Erro ao buscar dados da Api'))
    }
    feachDoador()
 
})

function abrirTelaDoador(){
    window.location.href = './pages/create.html';
}