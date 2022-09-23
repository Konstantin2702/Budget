(function () {
    const $datepicker = $('.js-datepicker');
    var disabledDates = [0, 6];

    let datepicker = $datepicker.datepicker({
        autoClose: true,
        classes: 'datepicker__calendar',
        position: 'bottom right',
        offset: 22,
        onRenderCell: function (date, cellType) {
            if (cellType == 'day') {
                let day = date.getDay();
                let isDisabled = disabledDates.indexOf(day) != -1;
                return {
                    disabled: isDisabled
                }
            }
        },
        onSelect: function (formattedDate, date, inst) {
            if (date) {
                alert(date);
            }
        }
    }).data('datepicker');

});