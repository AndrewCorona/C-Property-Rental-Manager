var PropertyList = [];
var UI = {};

function saveProperty() {

    //get values into vars
    var Title = UI.RTitle.val();
    var Location = UI.RLocation.val();
    var Bedrooms = parseInt(UI.RBeds.val());
    var Bathrooms = parseInt(UI.RBathrooms.val());
    var Price = parseFloat(UI.RPrice.val());
    var Area = parseInt(UI.RArea.val());
    var URLImage = UI.RImage.val();
    var Description = UI.RDescription.val();
    var Parking = UI.RParking.is(":checked");
    //data validations ***HOMEWORK*** make a nice one!
    if(!Price){ //if the price is: empty, 0, false, NaN
        $("#alertError").removeClass('hide');

        setTimeout( () => {$("#alertError").addClass('hide');} ,3000);

        return; //return means done, leave the function
    }
    if(!Bedrooms){
        $("#alertError2").removeClass('hide');

        setTimeout( () => {$("#alertError2").addClass('hide');} ,3000);
        return;
    }
    if(!Bathrooms){
        $("#alertError3").removeClass('hide');

        setTimeout( () => {$("#alertError3").addClass('hide');} ,3000);
        return;
    }
    if(!Area){
        $("#alertError4").removeClass('hide');

        setTimeout( () => {$("#alertError4").addClass('hide');} ,3000);
        return;
    }
    //create an object
    var property = new Property(Title,Location,Bedrooms,Bathrooms,Price,Area,URLImage,Description,Parking);
    console.log(property);
    PropertyList.push(property);
    //clear the form
    clearForm();
    //send the object to BE ***HOMEWORK*** create some sort of error/success notification that stuff got PUSHed correctly
    $.ajax({
        url: "/catalog/SaveProperty",
        type: "POST",
        data: JSON.stringify(property),
        contentType: "application/json",
        success: function(res){
            console.log(res);
            $("#hideAlert").removeClass("hide");
            setTimeout(function(){
                $("#hideAlert").addClass("hide");  
            },3000);
        },
        error: function(){
            $("#hideAlert2").removeClass("hide");
            setTimeout(function(){
                $("#hideAlert2").addClass("hide");  
            },3000);
        }
    });
}

function clearForm(){
    $(".control").val('');

}

function init(){
    console.log("Register Page");

    UI = {
        RTitle: $('#RentalTitle'),
        RLocation: $("#RentalLocation"),
        RBeds: $('#RentalBeds'),
        RBathrooms: $('#RentalBathrooms'),
        RPrice: $('#RentalPrice'),
        RArea: $('#RentalArea'),
        RImage: $('#RentalImage'),
        RDescription: $('#RentalDescription'),
        RParking: $('#RentalParking_0'),
    };
    //events
    $("#btnSave").click(saveProperty);
}


window.onload = init;