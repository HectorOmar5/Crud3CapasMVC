function llamarGet(url, funcrespuesta) {
    $.ajax({
        type: 'GET',
        url: url,
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "html",
        success: funcrespuesta,
        error: Response => alert(Response)
    })
}