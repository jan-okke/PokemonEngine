using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Delphox : Pokemon
	{
		public override string Name => "Delphox";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Magician() };
		public override Stats BaseStats => new Stats(75, 69, 72, 114, 100, 104);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Mysticalfire() },
			[1] = new List<Move>() { new Moves.Mysticalfire(), new Moves.Futuresight(), new Moves.Roleplay(), new Moves.Switcheroo(), new Moves.Shadowball(), new Moves.Scratch(), new Moves.Tailwhip(), new Moves.Ember(), new Moves.Howl() },
			[5] = new List<Move>() { new Moves.Ember() },
			[11] = new List<Move>() { new Moves.Howl() },
			[14] = new List<Move>() { new Moves.Flamecharge() },
			[18] = new List<Move>() { new Moves.Psybeam() },
			[22] = new List<Move>() { new Moves.Firespin() },
			[28] = new List<Move>() { new Moves.Luckychant() },
			[31] = new List<Move>() { new Moves.Lightscreen() },
			[38] = new List<Move>() { new Moves.Psyshock() },
			[45] = new List<Move>() { new Moves.Flamethrower() },
			[51] = new List<Move>() { new Moves.Willowisp() },
			[57] = new List<Move>() { new Moves.Psychic() },
			[62] = new List<Move>() { new Moves.Sunnyday() },
			[68] = new List<Move>() { new Moves.Magicroom() },
			[74] = new List<Move>() { new Moves.Fireblast() },
			[80] = new List<Move>() { new Moves.Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Blastburn(), new Moves.Calmmind(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Echoedvoice(), new Moves.Embargo(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Firepunch(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Laserfocus(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Magiccoat(), new Moves.Magicroom(), new Moves.Overheat(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Toxic(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override int Weight => 390;
		public override int ExpYield => 267;
		public override int CatchRate => 45;
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