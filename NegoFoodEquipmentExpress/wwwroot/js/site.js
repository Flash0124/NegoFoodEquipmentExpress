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
