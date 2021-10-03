﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class info : Form
    {
        public List<RootObject> myObj;
        public int count;
        public info()
        {
            InitializeComponent();
            textBox1.Text = "Зарядные станции для электромобилей\r\n" +

"Зарядная станция — элемент инфраструктуры, предоставляющий электроэнергию для зарядки аккумуляторного электротранспорта, такого как электромобили, электробусы и т.п.\r\n" +

"Оборудование для зарядки электромобилей может размещаться как в частных коттеджах, так и на улице: в общественных местах(стоянки перед торговыми центрами, кинотеатрами) или на специальных станциях по типу автомобильных заправочных станций.\r\n" +

"Современная ситуация в Москве\r\n" +

"В настоящее время в стране установлено порядка 60 зарядных станций. Развитие рынка электротранспорта в России началось в октябре 2011 года - с момента старта продаж первого в мире сертифицированного электромобиля на территории РФ.В Москве первые зарядные станции в рамках проекта \"МОЭСК-EV\" появились в феврале 2012 года.\r\n" +

"В рамках соглашений о сотрудничестве между Правительством Москвы с ПАО «Мосэнерго» и ПАО «Российские сети» по развитию использования электромобильной техники в городе Москве реализуется пилотный проект по вводу в эксплуатацию сети зарядных станций для электромобилей на объектах парковочного пространства города.\r\n" +

"06.10.2015 открыта первая зарядная станция для электромобилей на парковочном пространстве города Москвы по адресу: ул.Бахрушина, д. 20.\r\n" +

"На сегодняшний день, согласно пилотному проекту в городе Москве, в зоне платных парковок установлено и введено в эксплуатацию 16 ед.зарядных станций для электромобилей. \r\n" +

"Сеть зарядных станций будет расширяться и в будущем планируется развитие зарядной инфраструктуры, в пределах Третьего транспортного кольца(ТТК), а также на стоянках у торговых центров за ТТК.\r\n" +

"В рамках соглашений между Правительством Москвы и энергетических компаний планируется подключить в общей сложности порядка 150 станций.Зарядки разместятся в зоне платной парковки на улично-дорожной сети в пределах ТТК.\r\n" +

"А знаете ли вы что?\r\n" +

"Расширение инфраструктуры повысит экономическую эффективность и надежность энергетического обеспечения транспортного комплекса Москвы.Также это будет способствовать появлению на дорогах новых электромобилей, что сократит вредные выбросы в окружающую среду.\r\n" +

"В целях стимулирования использования электромобилей принято решение о не взимании платы за размещение электромобилей на городских объектах парковочного пространства в соответствии с постановлением Правительства Москвы от 17.05.2013 года № 289 - ПП «Об организации платных городских парковок в городе Москве»\r\n" +

"Получить карту для зарядки электромобиля и воспользоваться зарядной станцией ПАО «Российские сети»  можно в данной компании(подробная информация размещена на сайте).\r\n" +

"А запуск зарядной станции ПАО «Мосэнерго» производится при помощи карты «Тройка».\r\n" +

"Плата за пользование зарядной инфраструктуры до июня 2017 года взиматься не будет.\r\n" +

"Полноценная сеть зарядных станций на городских парковках в Москве создается в рамках соглашения между Правительством Москвы, Энергетическими и Электросетевыми компаниями ПАО «Мосэнерго» и ПАО «Российские сети»\r\n" +

"На период тестирования, запуск зарядной станции производится картой «Тройка», плата за услугу зарядки электромобиля не взимается.\r\n" +

"Зарядная сессия отключается только той картой, которой она была активирована.\r\n" +

"Контакт - центр для справок ПАО «Мосэнерго»: +7(495) 957 - 2500\r\n" +

"Инструкция по использованию.\r\n" +

"Start\r\n" +

"1.Поднести карту «Тройка» к считывающему устройству\r\n" +

"2.Нажать зелёную кнопку Start\r\n" +

"3.Открыть люк зарядной станции для доступа к розетке\r\n" +

"4.Вставить зарядный кабель в машину, затем в розетку зарядной станции.\r\n" +

"5.Индикатор загорается зелёным цветом, зарядка началась\r\n" +

"Stop\r\n" +

"1.Поднести карту «Тройка» к считывающему устройству\r\n" +

"2.Нажать красную кнопку Stop\r\n" +

"3.Вынуть зарядный кабель из розетки, затем из электромобиля\r\n" +

"ПАО «Российские сети»\r\n" +

"Запуск зарядной станции производится картой МОЭСК – EV.\r\n" +
"По вопросам выдачи и обслуживания карт и в случае утери карты, необходимо обращаться в ПАО «МОЭСК»\r\n" +

"Для получения карты клиента Вам необходимо иметь с собой паспорт и свидетельство о регистрации транспортного средства.\r\n" +
"Телефон «Светлой линии»: 8(800) 700 - 40 - 70\r\n" +

"Центральный клиентский офис: г.Москва, ул.А.Солженицына, д.7\r\n" +

"Время работы: пн. - сб.: 9:00 - 20:00(без перерыва на обед)\r\n" +

"http://www.moesk.ru/about/proect_ev/karta/index.php \r\n" +

"            Инструкция по использованию.\r\n" +

"Подключение\r\n" +

"Поднести карту в верхней части зарядной станции в центре светодиода на 4 сек.\r\n" +

"Открыть люк зарядной станции для доступа к розетке\r\n" +

"Вставить зарядный кабель в машину, затем в розетку зарядной станции.\r\n" +

"Закрыть люк зарядной станции. Индикатор загорелся синим цветом, зарядка началась\r\n" +

"Отключение\r\n" +

"Поднести карту в верхней части зарядной станции в центре светодиода на 4 сек.\r\n" +

"Открыть люк зарядной станции для доступа к розетке\r\n" +

"Вынуть зарядный кабель из розетки зарядной станции, затем из электромобиля.\r\n" +

"Закрыть люк зарядной станции – завершить зарядную сессию.Индикатор зарядной станции загорится зелёным.";
            
        }

    }
}
