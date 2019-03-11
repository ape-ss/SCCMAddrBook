# SCCM Address Book (version 1.5)
## Общая информация

Программа для работы с каталогом удаленных рабочих станций SCCM
(Аналог утилиты VNC Address Book)

##Изменения в версии 1.5

1. Программа полностью переписана. Теперь это приложение Windows Presentation Foundation;
2. Добавлено диалоговое окно настроек программы;
3. Добавлена возможность выбора типа удаленного рабочего стола ( к удаленному компьютеру 
   возможно подключиться как через SCCM Viewer, так и через Remote Assistant;
4. Доменное имя или IP-адрес удаленного компьютера автоматически определяется только
   в окне добавления/редактирования узла;
5. В контекстное меню узла добавлены команды подключения через SCCM Viewer и Remote Assistant.

## Краткая инструкция по работе с программой

1. Сразу после первого запуска, перед началом работы нужно указать
   программе путь к исполнимому файлу SCCM Viewer'а (в настройках программы);
2. Управление программой выполняется с помощью кнопочной панели
   в верхней части окна программы, контекстного меню или полосы главного меню;
3. Программа автоматически определяет и отображает в статусной строке общее количество узлов
   в списке и последний узел к которому подключались.
