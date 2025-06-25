



export function beforeWebStart(options) {
    console.log("before web start...");
}

export function afterWebStarted(blazor) {
    console.log("after web started...");
    JS_ParsePage();
    
    blazor.addEventListener("enhancedload", OnPageChanged);
}

function OnPageChanged() {
    console.log("enhanced navigation worked !!! ");
    JS_ParsePage();

}