var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/admin/product/getall",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "title", "width": "25%" },
            { "data": "isbn", "width": "15%" },
            { "data": "listPrice", "width": "10%" },
            { "data": "author", "width": "15%" },
            { "data": "category.name", "width": "10%" },
            {
                "data": null,
                "render": function (data, type, row) {
                    return `
                     <div class="d-flex justify-content-center align-items-center w-100">
                    <div class="w-75 btn-group" role="group">
                            <a href="/admin/product/upsert/${data.id}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"> </i>Edit</a>
                            
                            <a onClick=Delete('/admin/product/delete/${data.id}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"> </i>Delete</a>
                        </div>
                        </div>
                    `;
                },
                "width": "25%"
            }
        ]
    });
}
// burdaki olay yukarda onclick vermezsen çalışmaz.
// delete fonksiyonu çalıştıktan sonra sayfayı yenilediğimiz için dataTable tanımlaması yaptık ve reload ettik
function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}
