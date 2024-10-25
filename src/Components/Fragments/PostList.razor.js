const SEARCHBAR = document.getElementById("postSearchBar");

SEARCHBAR.addEventListener("input", SearchPosts);

function SearchPosts(e) {
    const userInput = e.target.value.toLowerCase();
    let x = document.querySelectorAll(".normal-post > .post");

    x.forEach((node) => {
        if (!node.querySelector(".card-title").textContent.toLowerCase().includes(userInput))
        {
            // console.log(node.querySelector(".card-title").textContent);
            node.classList.add("hidden");
        }else {
            node.classList.remove("hidden");
        }
    })
}
