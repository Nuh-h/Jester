export const MobileMenu = ():void => {
    const toggler: HTMLButtonElement = document.querySelector("button#mobile-menu-btn")!;

    const menu: HTMLElement = document.querySelector("#mobile-menu")!;

    let isOpen: boolean = false;

    toggler.addEventListener("click", (): void => {
        if (!isOpen) {
            toggler.classList.add("bg-[#0d6efd]/90");
            toggler.classList.add("text-white");
            menu.classList.remove("hidden");
            isOpen = true;
        } else {
            toggler.classList.remove("bg-[#0d6efd]/90");
            toggler.classList.remove("text-white");
            menu.classList.add("hidden");
            isOpen = false;
        }
    });
}