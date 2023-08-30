using Codice.CM.Client.Differences;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.EditorCoroutines.Editor;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;

namespace FD.Core.Editors
{

    //This code works only when the editor coroutine library is installed.
    //�� �ڵ�� ������ �ڷ�ƾ ���̺귯���� ��ġ�� ��쿡�� �����մϴ�
    public class FAED_GoogleFormParser : EditorWindow
    {

        protected void GetFromData(string documentID, string sheetID, Action<bool, string> process)
        {

            EditorCoroutineUtility.StartCoroutine(GetFormDataCo(documentID, sheetID, process), this);

        }

        private IEnumerator GetFormDataCo(string documentID, string sheetID, Action<bool, string> process)
        {

            string url = $"https://docs.google.com/spreadsheets/d/{documentID}/export?format=tsv&gid={sheetID}";
            UnityWebRequest res = UnityWebRequest.Get(url);

            yield return res.SendWebRequest();

            if(res.result == UnityWebRequest.Result.ConnectionError || res.responseCode != 200)
            {

                process?.Invoke(false, null);
                yield break;

            }

            process?.Invoke(true, res.downloadHandler.text);

        }

    }

}