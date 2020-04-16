function swapPic1() {
    $('#si-main-image').attr('src', $('#p1').attr('src'));
    
}
function swapPic2() {
    $('#si-main-image').attr('src', $('#p2').attr('src'));
}
function swapPic3() {
    $('#si-main-image').attr('src', $('#p3').attr('src'));
}

function loadHomePage() {

    var items = @Html.Raw(Json.Encode(Model));

    for (i = 0; i < items.length; i++) {
        var divCol = document.createElement('div');
        var divAtt = document.createAttribute('class');
        divAtt.value = 'col-md-6 col-lg-3 d-flex align-items-stretch';
        divCol.setAttributeNode(divAtt);
        divAtt = document.createAttribute('data-aos');
        divAtt.value = 'fade-up';
        divCol.setAttributeNode(divAtt);
        divAtt = document.createAttribute('data-aos-delay');
        divAtt.value = '200';
        divCol.setAttributeNode(divAtt);

        var divBox = document.createElement('div');
        divAtt = document.createAttribute('class');
        divAtt.value = 'icon-box icon-box-blue';
        divBox.setAttributeNode(divAtt);

        var divIcon = document.createElement('div');
        divAtt = document.createAttribute('class');
        divAtt.value = 'icon';
        divIcon.setAttributeNode(divAtt);

        var icon = document.createElement("i");
        iconAtt = document.createAttribute('class');
        iconAtt.value = 'bx bx-world';
        icon.setAttributeNode(iconAtt);

        var h4Title = document.createElement("h4");
        h4Att = document.createAttribute('class');
        h4Att.value = 'title';
        h4Title.setAttributeNode(h4Att);
        h4Title.textContent = "Nemo Enima";

        var para = document.createElement("p");
        paraAtt = document.createAttribute('class');
        paraAtt.value = 'description';
        para.setAttributeNode(paraAtt);
        para.textContent = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque";

        divIcon.appendChild(icon);
        divBox.appendChild(divIcon);
        divBox.appendChild(h4Title);
        divBox.appendChild(para);

        divCol.appendChild(divBox);

        var div = document.getElementById("tiles-div");
        div.appendChild(divCol);
}


