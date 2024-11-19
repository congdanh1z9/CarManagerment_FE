document.getElementById('toggleBtn').addEventListener('click', function () {
    var text = document.querySelector('.text');
    var button = this;

    if (text.style.maxHeight === '80px') {
        text.style.maxHeight = '1000px';  // Mở rộng phần nội dung
        button.textContent = 'Show Less'; // Đổi nút thành "Show Less"
    } else {
        text.style.maxHeight = '80px';  // Thu gọn phần nội dung
        button.textContent = 'Show More...';
    }
    text.style.transition = 'max-height 0.3s ease-out';
});

const thumbnails = document.querySelectorAll('.thumbnail');

thumbnails.forEach(function (thumbnail) {
    thumbnail.addEventListener('click', function () {
        const newSrc = thumbnail.src;

        document.getElementById('mainImage').src = newSrc;
    });
});

