$(document).ready(function () {
    // This function is executed when the document is fully loaded and ready

    $('#carouselExampleIndicators').on('slid.bs.carousel', function () {
        // This line attaches an event listener to the carousel when it finishes sliding to a new item
        // 'slid.bs.carousel' is an event that is fired after the carousel has completed its slide transition

        var index = $('.carousel-item.active').index();
        // This line gets the index of the currently active carousel item
        // The index is used to match the carousel item with the corresponding product description

        $('.product-description').hide();
        // This line hides all product descriptions to ensure that only the correct one is displayed

        $('.product-description').eq(index).show();
        // This line shows the product description that matches the currently active carousel item
        // 'eq(index)' selects the element at the specified index in the jQuery object
        // This ensures that only the description of the current carousel item is displayed
    });
});

$(document).ready(function () {
    // This function runs when the document (the web page) is fully loaded and ready
    $(window).scroll(function () {
        // This function runs every time the user scrolls the window
        if ($(window).scrollTop() + $(window).height() == $(document).height()) {
            // If the sum of the current vertical scroll position and the window height
            // is equal to the total height of the document, it means the user has scrolled
            // to the bottom of the page
            $("#footer").fadeIn(); // Show the footer by fading it in
        } else {
            // If the user has not scrolled to the bottom of the page
            $("#footer").fadeOut(); // Hide the footer by fading it out
        }
    });
});

