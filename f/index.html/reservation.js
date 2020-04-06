$(document).ready(function() {
	var emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;

	$('#arrival_date').focus();

	$('#reservation_form').submit(function(event) {

		var name = $('#name').val().trim();
        var arrivalDate = $('#arrival_date').val().trim();
        var email = $('#email').val().trim();
		var numOfNights = $('#nights').val().trim();
		var phone = $('#phone').val().trim();
        
        var isCorrect = true;
		
		if (!name) {
			isCorrect = false;
			$('#name').next().text('This field is required.');
		}
        
        if (!arrivalDate) {
			isValid = false;
			$('#arrival_date').next().text('This field is required.');
		}

		if (!email) {
			isCorrect = false;
			$('#email').next().text('This field is required.');
		} else if (!emailPattern.test(email)) {
			isCorrect = false;
			$('#email').next().text('Wrong email format.');
		}
        
        if (!numOfNights) {
			isCorrect = false;
			$('#nights').next().text('This field is required.');
		} else if (isNaN(numOfNights)) {
			isCorrect = false;
			$('#nights').next().text('Number of nights has to be a number.');
		}


		if (!phone) {
			isCorrect = false;
			$('#phone').next().text('This field is required.');
		}

		if (!isCorrect) { event.preventDefault() }
	});
});