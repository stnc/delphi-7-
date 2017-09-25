unit procedurler;

interface

implementation

  procedure SetMPVolume(MP: TMediaPlayer; Volume: Integer);
  { Volume: 0 - 1000 }
var
  p: MCI_DGV_SETAUDIO_PARMS;
begin
  { Volume: 0 - 1000 }
  p.dwCallback := 0;
  p.dwItem := MCI_DGV_SETAUDIO_VOLUME;
  p.dwValue := Volume;
  p.dwOver := 0;
  p.lpstrAlgorithm := nil;
  p.lpstrQuality := nil;
  mciSendCommand(MP.DeviceID, MCI_SETAUDIO,
    MCI_DGV_SETAUDIO_VALUE or MCI_DGV_SETAUDIO_ITEM, Cardinal(@p));
end;
end.
 