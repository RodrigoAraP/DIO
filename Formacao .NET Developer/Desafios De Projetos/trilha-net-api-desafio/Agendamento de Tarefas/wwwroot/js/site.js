document.addEventListener("DOMContentLoaded", () => {
    const filtro = document.querySelector("select[name='filtro']")
    const container = document.querySelector("#valorContainer")

    if (!filtro || !container) return;


    const inputTexto = () => {
        const input = document.createElement('input')
        input.name = 'valor'
        input.className = 'form-control  w-auto'
        input.type = 'text'
        input.value = ''
        return input
    }

    const inputData = () => {
        const input = document.createElement('input')
        input.name = 'valor'
        input.className = 'form-control  w-auto'
        input.type = 'date'
        input.value = ''
        return input
    }

    const selectStatus = () => {
        const select = document.createElement('select')
        select.name = 'valor'
        select.className = 'form-select  w-auto'

        const statusList = ['Pendente', 'EmAndamento', 'Concluida']

        statusList.forEach(s => {
            const opt = document.createElement('option')
            opt.value = s
            opt.textContent = s
            select.appendChild(opt)
        })

        return select 
    }

    const atualizar = () => {
        const opt = filtro.value

        container.innerHTML = ''

        switch (opt) {
            case 'Titulo':
                container.appendChild(inputTexto())
                break
            case 'Data':
                container.appendChild(inputData())
                break
            case 'Status':
                container.appendChild(selectStatus())
                break
        }
    }

    filtro.addEventListener('change', atualizar)
    atualizar()
})