namespace developer0223._20240417
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    using developer0223._20240410;

    using LitJson;

    public class AudioManager : MonoSingleton<AudioManager>
    {
        [SerializeField] private AudioSource bgmSource = null;
        [SerializeField] private AudioSource effectSource = null;

        // Singleton ������ �̿��ؼ� ����

        /// <summary>
        /// BGM�� ����ϴ� �Լ� 2��
        /// </summary>
        /// <param name="clip"></param>
        public void PlayBGM(AudioClip clip)
        {
            if (bgmSource == null)
            {
                //Debug.LogWarning();
                return;
            }
            // AudioClip�� �޾Ƽ� bgmSource���� ���
            bgmSource.clip = clip;
            bgmSource.Play();
        }

        public void Callee()
        {
            try
            {
                Test("ttt");
            }
            catch (ABCNotExistException e)
            {
                Debug.Log(e.ToString());
            }
            catch
            {
                Debug.Log("Unknown error");
            }
            
        }

        public void Test(string text)
        {
            // �� �ؽ�Ʈ�� �� ABC��� ���ڿ��� ���ԵǾ��־�� ��
            // Custom Exception�� ���� ��������
            if (!text.Contains("ABC"))
            {
                Debug.LogError("");
                throw new ABCNotExistException();
            }    
        }

        public class ABCNotExistException : System.Exception
        {

        }

        public void PlayBGM(AudioClip clip, float volume)
        {
            // AudioClip�� �޾Ƽ� bgmSource���� ���, bgmSource�� volume�� �缳��
            // case 1. PlayBGM�� �ִ� �ڵ���� �Ȱ��� �����Ͽ� �ۼ�, �׸��� volume�� ���� ����
            bgmSource.volume = volume;
            bgmSource.clip = clip;
            bgmSource.Play();

            // case 2. volume�� ���� �缳�� �� PlayBGM(AudioClip) �Լ��� ����
            bgmSource.volume = volume;
            PlayBGM(clip);
        }

        // Effect�� ����ϴ� �Լ� 2��
        public void PlayEffect(AudioClip clip)
        {
            // AudioClip�� �޾Ƽ� effectSource���� ���
            // case 1: ���� ����
            effectSource.clip = clip;
            effectSource.Play();

            // case 2: PlayOneShot �޼��� ���
            effectSource.PlayOneShot(clip);
        }

        public void PlayEffect(AudioClip clip, float volume)
        {
            // AudioClip�� �޾Ƽ� effectSource���� ���, bgmSource�� volume�� �缳��
            // case 1: ���� ����
            effectSource.volume = volume;
            effectSource.clip = clip;
            effectSource.Play();

            // case 2: PlayOneShot �޼��� ���
            effectSource.PlayOneShot(clip, volume);
        }
    }
}