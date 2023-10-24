// ViewportAbstraction.js

var ViewportAbstraction = (function () {
    function updateVmin() {
        var viewportWidth = window.innerWidth;
        var viewportHeight = window.innerHeight;
        var vmin = Math.min(viewportWidth, viewportHeight);

        if (vmin >= 0 && vmin <= 65535) {
            console.log("About to call C# method");
            DotNet.invokeMethodAsync('Style', 'UpdateVmin', vmin)
                .then(result => console.log("C# method called", result))
                .catch(error => console.error("Error while calling C# method", error));
        }
    }

    window.addEventListener('resize', function () {
        updateVmin();
    });

    updateVmin();

    return {
        // Expose public functions or variables here, if needed.
    };
})();