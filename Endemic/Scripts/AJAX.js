
function mostrarTabla(id) {

    $.ajax({
        url: "LlenarTabla",
        type: 'GET',
        dataType: 'json',
        data:{id:id},
        cache: false,
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            var html = "";
            for (x in data) {
                var id = data[x].Id;
                var nombre = data[x].Nombre;
                var duracion = data[x].Duracion;
                var direccion = data[x].Direccion;
                html += "<tr>" +
                    "<td>" + id + "</td>" +
                    "<td>" + nombre + "</td>" +
                    "<td>" + duracion + "</td>" +
                    "<td>" + "<audio controls='controls'>  <source src='" + direccion + "' type= audio/mpeg /> </audio > " + "</td >" +
                    "</tr>";
            }
            $("#canciones").find('tbody').append(html);

        }

    });
    return false;
}

function buscarAlbum() {
    var busqueda = document.getElementById("txtBusqueda").value;
    $.ajax({
        url: "/Home/buscarAlbum",
        type: 'GET',
        dataType: 'json',
        data: { busqueda: busqueda },
        cache: false,
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            var html = "";
            for (x in data) {
                var id = data[x].id;
                var nombre = data[x].Nombre;
                var imagen = data[x].imagen;
                html += '<div class='+'"col-md-3 content-grid">'+
                            '<a href='+'"/Home/ViewPlaylist/'+id+'"'+'><img src='+'"'+imagen+'"'+'title="'+nombre+'"'+'></a>'+
                        '</div>';
            }
            $("#albumPrincipal").find("div").remove();
            $("#albumPrincipal").append(html);

        }

    });
    return false;
}

function mostrarAlbum() {
    var selectedBox = document.getElementById("comboAlbumes")
    var id = selectedBox.options[selectedBox.selectedIndex].id;
    $.ajax({
        url: "/Home/obtenerAlbum",
        type: 'GET',
        dataType: 'json',
        data: { id: id },
        cache: false,
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            var html = "";
            var infAlbum = "<img id="+"'imagenAlbum'"+ "src='"+data.imagen+"' width='"+"70%'"+" ; alt=''>"+
                "<h3 class='tittle'" + ">"+data.Nombre+"<span id='" + data.Artista.Nombre + "' font-size:15px;><br>" + data.Artista.Nombre + "</span><br><span id='" + data.anioAlbum + "' font-size: 18px;>" + data.Anio + "</span></h3>";
            for (x in data.Canciones) {
                var id = data.Canciones[x].Id;
                var nombre = data.Canciones[x].Nombre;
                var duracion = data.Canciones[x].Duracion;
                var direccion = data.Canciones[x].Direccion;
                html += "<tr>" +
                    "<td>" + id + "</td>" +
                    "<td>" + nombre + "</td>" +
                    "<td>" + duracion + "</td>" +
                    "<td>" + "<audio controls='controls'>  <source src='" + direccion + "' type= audio/mpeg /> </audio > " + "</td >" +
                    "</tr>";
            }
            $("#infAlbum").find("h3").remove();
            $("#infAlbum").find("img").remove();
            $("#canciones").find("tr").remove();
            $("#canciones").find('tbody').append(html);
            $("#infAlbum").append(infAlbum);

        }

    });
    return false;
}


function obtenerAlbumes() {

    $.ajax({
        url: "obtenerAlbumes",
        type: 'GET',
        dataType: 'json',
        cache: false,
        contentType: "application/json; charset=utf-8",
        success: function (data) {
            var html = "";
            for (x in data) {
                var id = data[x].id;
                var nombre = data[x].Nombre;
                html +=
                    '<option id="'+id+'"'+' value="'+nombre+'">'+nombre+'</option>';
            }
            $("#comboAlbumes").find('select').append(html);

        }

    });
    return false;
}
