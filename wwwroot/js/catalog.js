
function fetchData(){
    $.ajax({
        url: "/catalog/getProperties",
        type: "GET",
        success: (data) => {
           console.log(data);
           for(let i=0; i<data.length; i++){
               displayProperty(data[i]);
           }
        },
        error: (details) => {
            console.log("Error", details);
        },
    });
}



function displayProperty(property){
    //create the syntax
    const yesparkingicon = '<i class="fas fa-parking"></i>';
    const noparkingicon = '<i class="fas fa-parking"></i>';


      if (property.parking === "true") {
        parkingicon = yesparkingicon;
      }
    else {
      parkingicon = noparkingicon;
    }
    var syntax =


`<div class="card">
  <img src='${property.urlImage}' class="card-img-top" alt="image of home">
  <div class="detailslist">
  <div class="detailsitem1"><i class="fas fa-users"></i>${property.bedrooms*2}</div>
  <div class="detailsitem2"><i class="fas fa-bed"></i>${property.bedrooms}</div>
  <div class="detailsitem3"><i class="fas fa-sink"></i>${property.bathrooms}</div>
  </div>
    <h5 class="card-title"> <a href="#">${property.title}, ${parkingicon}</a></h5>
    <class="card-location">${property.location}
    <p class="card-text">listed<strong>$${property.price}</strong> /night</p>
  </div>

</div>`;

    //get the container
    var container = $("#catalog-container");

    //append syntax to container
    container.append(syntax);
  };


function testDelete() {
    var id = 6;

    $.ajax({
      url: "/catalog/DeleteProperty/" + id,
      type: "DELETE",
      success: () => {
        console.log("deleted");
      },
      error: (details) => {
        console.log("Error", details);
      },
    });
  }
  

function init(){
    console.log("Catalog Page");

    fetchData();
}
window.onload = init;

//ajax delete /catalog/DeleteProperty/2