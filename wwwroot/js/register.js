var PropertyList = [];
var UI = {};

function saveProperty() {

    //get values into vars
    var Title = UI.RTitle.val();
    var Bedrooms = parseInt(UI.RBeds.val());
    var Bathrooms = parseInt(UI.RBathrooms.val());
    var Price = parseFloat(UI.RPrice.val());
    var Area = parseInt(UI.RArea.val());
    var URLImage = UI.RImage.val();
    var Description = UI.RDescription.val();
    var Parking = UI.RParking.is(":checked");
    //data validations ***HOMEWORK*** make a nice one!
    if(!Price){ //if the price is: empty, 0, false, NaN
        alert("Error, verify the input on your Price input")
        return; //return means done, leave the function
    }
    if(!Bedrooms){
        alert("Error, verify the input on your Bedrooms input")
        return;
    }
    if(!Bathrooms){
        alert("Error, verify the input on your Bathrooms input")
        return;
    }
    if(!Area){
        alert("Error, verify the input on your Area input")
        return;
    }
    //create an object
    var property = new Property(Title,Bedrooms,Bathrooms,Price,Area,URLImage,Description,Parking);
    console.log(property);
    PropertyList.push(property);
    //clear the form
    clearForm();
    //send the object to BE
    $.ajax({
        url: "/catalog/SaveProperty",
        type: "POST",
        data: JSON.stringify(property),
        contentType: "application/json",
        success: (res) => {
            console.log(res);
        },
        error: (details) =>{
            console.log("Error", details);
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