var quill;
$(() => quill = new Quill('#quill', {
    theme: 'snow'
}));

$("#form").on("submit", () => {
    $('#quillImage').val($("#quill > .ql-editor > * > img, image").first().attr('src'));
    $("#quillInput").val($("#quill > .ql-editor").html());
});