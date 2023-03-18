using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Diancie : Pokemon
	{
		public override string Name => "Diancie";
		public override List<Ability> AvailableAbilities => new() {new Clearbody() };
		public override Stats BaseStats => new Stats(50, 100, 150, 100, 150, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden() },
			[7] = new List<Move>() { new Guardsplit() },
			[14] = new List<Move>() { new Smackdown() },
			[21] = new List<Move>() { new Flail() },
			[28] = new List<Move>() { new Ancientpower() },
			[35] = new List<Move>() { new Rockpolish() },
			[42] = new List<Move>() { new Lightscreen() },
			[49] = new List<Move>() { new Rockslide() },
			[56] = new List<Move>() { new Skillswap() },
			[63] = new List<Move>() { new Powergem() },
			[70] = new List<Move>() { new Stealthrock() },
			[77] = new List<Move>() { new Moonblast() },
			[84] = new List<Move>() { new Stoneedge() },
			[91] = new List<Move>() { new Diamondstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Amnesia(), new Batonpass(), new Bodypress(), new Calmmind(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Earthpower(), new Encore(), new Endure(), new Facade(), new Faketears(), new Gigaimpact(), new Guardswap(), new Gyroball(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Lightscreen(), new Meteorbeam(), new Metronome(), new Mistyexplosion(), new Mysticalfire(), new Playrough(), new Powergem(), new Protect(), new Psychic(), new Psyshock(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Skillswap(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stoneedge(), new Storedpower(), new Substitute(), new Sunnyday(), new Terrainpulse(), new Trickroom(), new Wonderroom() };
		public override int Weight => 88;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}