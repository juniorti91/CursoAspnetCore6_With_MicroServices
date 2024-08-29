// datatables-pt-br.js

$(document).ready(function () {
    $('#tbProduct').DataTable({
        "paging": true,
        "lengthChange": true,
        "searching": true,
        "ordering": true,
        "info": true,
        "autoWidth": true,
        "language": {
            "sProcessing": "Processando...",
            "sLengthMenu": "Mostrar _MENU_ entradas",
            "sZeroRecords": "Nenhum registro encontrado",
            "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ entradas",
            "sInfoEmpty": "Mostrando 0 até 0 de 0 entradas",
            "sInfoFiltered": "(filtrado de _MAX_ entradas no total)",
            "sSearch": "Buscar:",
            "oPaginate": {
                "sFirst": "Primeiro",
                "sPrevious": "Anterior",
                "sNext": "Próximo",
                "sLast": "Último"
            },
            "oAria": {
                "sSortAscending": ": ativar para ordenar colunas de forma ascendente",
                "sSortDescending": ": ativar para ordenar colunas de forma descendente"
            }
        }
    });
});