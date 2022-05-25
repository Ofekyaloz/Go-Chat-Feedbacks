$(function () {
    $('form').submit(e => {
        e.preventDefault();

        const q = $('#search').val();
        $('tbody').load('Feedbacks/Search2?query=' + q);
        $('#search').val('')
    })
});
