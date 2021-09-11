jQuery.validator.unobtrusive.adapters.add("checkbox", function (options) {
    if (options.element.tagName.toUpperCase() == "INPUT" && options.element.type.toUpperCase() == "CHECKBOX") {
        options.rules["required"] = true;
        if (options.message) {
            options.messages["required"] = options.message;
        }
    }
});

$(document).ready(function () {  

    var ddlCountry = $('#Country');
    ddlCountry.append($("<option></option>").val('').html('Please Select Country'));
    $.ajax({
        url: 'https://localhost:44326/api/AddressData/Countries',
        type: 'GET',
        dataType: 'json',
        success: function (d) {
            $.each(d, function (i, country) {
                ddlCountry.append($("<option></option>").val(country.countryID).html(country.country));
            });
        },
        error: function () {
            alert('Error!');
        }
    });


    //City Bind By Country id  
    $("#Country").change(function () {
        var CountryID = parseInt($(this).val());
        if (!isNaN(CountryID)) {
            var ddlCity = $('#City');
            ddlCity.append($("<option></option>").val('').html('Please wait ...'));

            $.ajax({
                url: 'https://localhost:44326/api/AddressData/Cities',
                type: 'GET',
                dataType: 'json',
                data: { countryID: CountryID },
                success: function (d) {


                    ddlCity.empty(); // Clear the plese wait  
                    ddlCity.append($("<option></option>").val('').html('Select City Name'));
                    $.each(d, function (i, cities) {
                        ddlCity.append($("<option></option>").val(cities.cityId).html(cities.city));
                    });
                },
                error: function () {
                    alert('Error!');
                }
            });
        }
    });
});  