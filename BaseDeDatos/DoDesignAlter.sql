--alter table nombreTabla
--add foreign key(parametro) references TablaRefencia

use DoDesign
go


----------------------------------------------------------------
--alter table Design
--add constraint FK_DesignUsers 
--foreign key(Usuario)references Users(Usuario);
--------------------------------------------------------------
alter table Polo
add constraint FK_DesignPolo 
foreign key(IdDesign)references Design(IdDesign), 
constraint FK_ColorPolo 
foreign key(IdColor)references Color(IdColor);
------------------------------------------------------------------------------
alter table Cliente
add constraint FK_CliTLogin
foreign key(IdTLogin)references TLogin(IdTLogin);
-------------------------------------------------------------------------
alter table Pedido
add constraint FK_PedPolo
foreign key (IdPolo) references Polo(IdPolo),
constraint FK_PedCliente
foreign key (IdCliente) references Cliente(IdCliente),
constraint FK_PedPago
foreign key (IdPago) references Pago(IdPago);
-----------------------------------------------------------------------------------
alter table DetallePedido
add constraint FK_DetaPedPedido
foreign key(IdPedido)references Pedido(IdPedido);


