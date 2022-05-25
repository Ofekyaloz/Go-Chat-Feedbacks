$(function () {
    $('form').submit(e => {
        e.preventDefault();

        const q = $('#search').val();

        $('tbody').load('Feedbacks/Search?query=' + q);
    })
});
