
function send() {
    let name = document.getElementById('inputName').value;
    let phone = document.getElementById('inputPhone').value;
    let email = document.getElementById('inputMail').value;
    let message = document.getElementById('inputMessage').value;
    const regexPhone = /^\d{10}$/;
    const regexMail = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?)*$/
;

    if (name != '') {
        if (regexPhone.test(phone)) {
            if (regexMail.test(email)) {
                $.ajax({
                    url: '/Home/Contacto',
                    method: 'POST',
                    data: {
                        name: name,
                        phone: phone,
                        email: email,
                        message: message
                    },
                    success: function (response) {
                        Swal.fire({
                            title: "Enviado",
                            text: "Datos Enviados Correctamente",
                            icon: "success"
                        }).then((result)=> {
                            if (result.isConfirmed) {
                                window.location.href ="/Home/Index";
                            }
                        });
                    },
                    error: function (error) {
                        Swal.fire({
                            title: "Error",
                            text: "A ocurrido un error",
                            icon: "error"
                        });
                    },
                });
            }
            else {
                Swal.fire({
                    title: "Error",
                    text: "No es un formato de correo válido",
                    icon: "error"
                });
            }
        }
        else {
            Swal.fire({
                title: "Error",
                text: "No es un numero de teléfono válido, recuerda colocar a 10 digitos",
                icon: "error"
            });
        }
    }
    else {
        Swal.fire({
            title: "Error",
            text: "El campo nombre no puede estar vacío",
            icon: "error"
        });
    }
}