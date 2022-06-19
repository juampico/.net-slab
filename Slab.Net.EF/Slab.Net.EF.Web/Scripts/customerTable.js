const $tableID = $('#table'); const $BTN = $('#export-btn'); const $EXPORT = $('#export');




$tableID.on('click', '.table-update', function () {
    const $row = $(this).parents('tr');
    if ($row.index() === 0) {
        return;
    }
    $row.prev().before($row.get(0));
});