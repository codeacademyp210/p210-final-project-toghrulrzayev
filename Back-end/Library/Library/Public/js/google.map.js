
google.maps.event.addDomListener(window, 'load', init);

function init() {
    
    var mapOptions = {
      
        zoom: 15,

       
        center: new google.maps.LatLng(-37.815799, 144.956113),
        disableDefaultUI: false,
        
    };

    
    var mapElement = document.getElementById('map');

    // Create the Google Map using our element and options defined above
    var map = new google.maps.Map(mapElement, mapOptions);

   
    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(-37.815799, 144.956113),
        map: map,
        mapTypeControl: true
    });
}