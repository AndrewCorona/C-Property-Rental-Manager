
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
    var syntax = 

`<div class="card" style="width:32rem;">
  <img src='${property.urlImage}' class="card-img-top" alt="image of home" width="531" height="350">
 
    <h5 class="card-title"> <a href="#">${property.title}</a></h5>
    <class="card-location">${property.location}
    <p class="card-text">from <strong>$${property.price}</strong> /night</p>
  </div>

</div>`;

    //get the container
    var container = $("#catalog-container");

    //append syntax to container
    container.append(syntax);
}

function testDelete() {
    var id = 1;

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