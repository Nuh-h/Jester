import tinymce from "tinymce";

export const Editor = () => tinymce.init({
    selector: 'textarea#story',  // change this value according to your HTML
    license_key: "gpl",
    base_url: "/js/tinymce",
    promotion: false,
    plugins: 'code',
    toolbar: 'undo redo | bold italic | alignleft aligncenter alignright alignjustify | indent outdent | wordcount | code',
});