// On page load, set up the Quiil editor.
var quill;
$(() => quill = new Quill('#quill', {
    theme: 'snow'
}));

// Pull out the first image for a preview, then submit the entire field as content.
$("#form").on("submit", () => {
    $('#quillImage').val($("#quill > .ql-editor > * > img, image").first().attr('src'));
    $("#quillInput").val($("#quill > .ql-editor").html());
});