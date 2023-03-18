using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Alakazam : Pokemon
	{
		public override string Name => "Alakazam";
		public override List<Ability> AvailableAbilities => new() {new Synchronize(), new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Magicguard() };
		public override Stats BaseStats => new Stats(55, 50, 45, 120, 135, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Confusion(), new Kinesis(), new Disable(), new Teleport() },
			[5] = new List<Move>() { new Psybeam() },
			[10] = new List<Move>() { new Reflect() },
			[15] = new List<Move>() { new Allyswitch() },
			[20] = new List<Move>() { new Psychocut() },
			[25] = new List<Move>() { new Recover() },
			[30] = new List<Move>() { new Psyshock() },
			[35] = new List<Move>() { new Psychic() },
			[40] = new List<Move>() { new Roleplay() },
			[45] = new List<Move>() { new Futuresight() },
			[50] = new List<Move>() { new Calmmind() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bodyslam(), new Calmmind(), new Chargebeam(), new Dazzlinggleam(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Foulplay(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Imprison(), new Irontail(), new Lightscreen(), new Magicroom(), new Megakick(), new Megapunch(), new Metronome(), new Nastyplot(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Speedswap(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Thunderpunch(), new Thunderwave(), new Torment(), new Triattack(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 480;
		public override int ExpYield => 250;
		public override int CatchRate => 50;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}