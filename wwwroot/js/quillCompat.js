var quill;
$(() => quill = new Quill('#quill', {
    theme: 'snow'
}));

$("#form").on("submit", () => {
    $("#quillInput").val($("#quill > .ql-editor").html());
});